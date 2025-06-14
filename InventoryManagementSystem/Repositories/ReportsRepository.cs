using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem.Repositories
{
    public class ReportsRepository
    {
        private readonly Database db;

        public ReportsRepository()
        {
            db = new Database();
        }

        // 1. Stock Turnover Report
        public DataTable GetStockTurnoverReport()
        {
            string query = @"
                SELECT 
                    p.sku,
                    p.name,
                    COUNT(sm.movement_id) AS movement_count,
                    SUM(ABS(sm.quantity_changed)) AS total_movement
                FROM products p
                JOIN stock_movements sm ON p.sku = sm.product_sku
                GROUP BY p.sku, p.name
                ORDER BY total_movement DESC;
            ";

            try
            {
                return db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to generate Stock Turnover Report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        // 2. Most Ordered Products Report
        public DataTable GetMostOrderedProductsReport()
        {
            string query = @"
                SELECT 
                    p.sku,
                    p.name,
                    SUM(oi.quantity) AS total_ordered,
                    SUM(oi.quantity * oi.price_each) AS total_spent
                FROM products p
                JOIN order_items oi ON p.sku = oi.product_sku
                GROUP BY p.sku, p.name
                ORDER BY total_ordered DESC;
            ";

            try
            {
                return db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to generate Most Ordered Products Report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        // 3. Supplier Performance Report
        public DataTable GetSupplierPerformanceReport()
        {
            string query = @"
                SELECT 
                    s.supplier_name,
                    COUNT(o.order_id) AS total_orders,
                    SUM(oi.quantity) AS total_items_ordered,
                    SUM(oi.quantity * oi.price_each) AS total_amount
                FROM suppliers s
                LEFT JOIN orders o ON s.supplier_id = o.supplier_id
                LEFT JOIN order_items oi ON o.order_id = oi.order_id
                GROUP BY s.supplier_name
                ORDER BY total_amount DESC;
            ";

            try
            {
                return db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to generate Supplier Performance Report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}

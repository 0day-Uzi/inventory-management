using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    public class StockMovementRepository
    {
        private readonly Database db;

        public StockMovementRepository()
        {
            db = new Database();
        }

        public bool AddStockMovement(StockMovement m)
        {
            string query = $"INSERT INTO stock_movements (product_sku, movement_type, quantity_changed, notes) VALUES (" +
                           $"'{m.ProductSKU}', '{m.MovementType}', {m.QuantityChanged}, " +
                           $"{(string.IsNullOrEmpty(m.Notes) ? "NULL" : $"'{m.Notes}'")})";

            return db.ExecuteNonQuery(query);
        }

        public List<StockMovement> GetMovementsBySKU(string sku)
        {
            List<StockMovement> movements = new List<StockMovement>();
            string query = $"SELECT * FROM stock_movements WHERE product_sku = '{sku}' ORDER BY movement_time DESC";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    StockMovement m = new StockMovement
                    {
                        MovementId = Convert.ToInt32(row["movement_id"]),
                        ProductSKU = row["product_sku"].ToString(),
                        MovementType = row["movement_type"].ToString(),
                        QuantityChanged = Convert.ToInt32(row["quantity_changed"]),
                        MovementTime = Convert.ToDateTime(row["movement_time"]),
                        Notes = row["notes"]?.ToString()
                    };
                    movements.Add(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch stock movements: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return movements;
        }

        public List<StockMovement> GetAllMovements()
        {
            List<StockMovement> movements = new List<StockMovement>();
            string query = "SELECT * FROM stock_movements ORDER BY movement_time DESC";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    StockMovement m = new StockMovement
                    {
                        MovementId = Convert.ToInt32(row["movement_id"]),
                        ProductSKU = row["product_sku"].ToString(),
                        MovementType = row["movement_type"].ToString(),
                        QuantityChanged = Convert.ToInt32(row["quantity_changed"]),
                        MovementTime = Convert.ToDateTime(row["movement_time"]),
                        Notes = row["notes"]?.ToString()
                    };
                    movements.Add(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch stock movements: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return movements;
        }
    }
}

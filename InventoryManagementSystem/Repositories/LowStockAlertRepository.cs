using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    public class LowStockAlertRepository
    {
        private readonly Database db;

        public LowStockAlertRepository()
        {
            db = new Database();
        }

        public List<LowStockAlert> GetAllAlerts()
        {
            List<LowStockAlert> alerts = new List<LowStockAlert>();
            string query = "SELECT * FROM low_stock_alerts";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    LowStockAlert a = new LowStockAlert
                    {
                        AlertID = Convert.ToInt32(row["alert_id"]),
                        ProductSku = row["product_sku"].ToString(),
                        AlertTime = Convert.ToDateTime(row["alert_time"]),
                        CurrentQuantity = Convert.ToInt32(row["current_quantity"]),
                    };
                    alerts.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch products: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return alerts;
        }

    }
}

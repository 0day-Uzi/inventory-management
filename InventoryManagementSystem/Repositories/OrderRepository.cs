using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    public class OrderRepository
    {
        private readonly Database db;

        public OrderRepository()
        {
            db = new Database();
        }

        // ✅ Add a new order with items
        public bool AddOrder(Order order, List<OrderItem> items)
        {
            try
            {
                // Step 1: Insert order (without user_id, with order_status)
                string orderQuery = $"INSERT INTO orders (supplier_id, total_amount, order_status) VALUES (" +
                                    $"{(order.SupplierId.HasValue ? order.SupplierId.ToString() : "NULL")}, " +
                                    $"{order.TotalAmount}, " +
                                    $"'{order.OrderStatus}')";

                MySqlCommand cmd = new MySqlCommand(orderQuery, db.OpenConnection());
                int result = cmd.ExecuteNonQuery();

                if (result <= 0)
                {
                    db.CloseConnection();
                    return false;
                }

                // Step 2: Retrieve the order ID
                cmd.CommandText = "SELECT LAST_INSERT_ID()";
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Step 3: Insert order items
                foreach (OrderItem item in items)
                {
                    string itemQuery = $"INSERT INTO order_items (order_id, product_sku, quantity, price_each) VALUES (" +
                                       $"{orderId}, '{item.ProductSKU}', {item.Quantity}, {item.PriceEach})";

                    MySqlCommand itemCmd = new MySqlCommand(itemQuery, db.GetRawConnection());
                    int rows = itemCmd.ExecuteNonQuery();

                    if (rows <= 0)
                    {
                        db.CloseConnection();
                        return false;
                    }
                }

                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to create order: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.CloseConnection();
                return false;
            }
        }

        // ✅ Fetch all orders
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            string query = "SELECT * FROM orders ORDER BY order_date DESC";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    orders.Add(new Order
                    {
                        OrderId = Convert.ToInt32(row["order_id"]),
                        OrderDate = Convert.ToDateTime(row["order_date"]),
                        SupplierId = row["supplier_id"] != DBNull.Value ? Convert.ToInt32(row["supplier_id"]) : (int?)null,
                        TotalAmount = Convert.ToDecimal(row["total_amount"]),
                        OrderStatus = row["order_status"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch orders: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orders;
        }

        // ✅ Fetch items for a specific order
        public List<OrderItem> GetItemsByOrderId(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();
            string query = $"SELECT * FROM order_items WHERE order_id = {orderId}";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    items.Add(new OrderItem
                    {
                        OrderItemId = Convert.ToInt32(row["order_item_id"]),
                        OrderId = Convert.ToInt32(row["order_id"]),
                        ProductSKU = row["product_sku"].ToString(),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        PriceEach = Convert.ToDecimal(row["price_each"])
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch order items: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return items;
        }

        public bool MarkOrderAsReceived(int orderId)
        {
            string query = $"UPDATE orders SET order_status = 'received' WHERE order_id = {orderId}";

            try
            {
                return db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to update order status: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}

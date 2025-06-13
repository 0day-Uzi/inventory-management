using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    public class ProductRepository
    {
        private readonly Database db;

        public ProductRepository()
        {
            db = new Database();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM products";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    Product p = new Product
                    {
                        SKU = row["sku"].ToString(),
                        Name = row["name"].ToString(),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        Price = Convert.ToDecimal(row["price"]),
                        SupplierId = row["supplier_id"] != DBNull.Value ? Convert.ToInt32(row["supplier_id"]) : (int?)null
                    };
                    products.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch products: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        public Product GetProductBySKU(string sku)
        {
            string query = $"SELECT * FROM products WHERE sku = '{sku}'";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    return new Product
                    {
                        SKU = row["sku"].ToString(),
                        Name = row["name"].ToString(),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        Price = Convert.ToDecimal(row["price"]),
                        SupplierId = row["supplier_id"] != DBNull.Value ? Convert.ToInt32(row["supplier_id"]) : (int?)null
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch product: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public bool AddProduct(Product p)
        {
            string query = $"INSERT INTO products (sku, name, quantity, price, supplier_id) VALUES (" +
                           $"'{p.SKU}', '{p.Name}', {p.Quantity}, {p.Price}, {(p.SupplierId.HasValue ? p.SupplierId.ToString() : "NULL")})";

            return db.ExecuteNonQuery(query);
        }

        public bool UpdateProduct(Product p)
        {
            string query = $"UPDATE products SET " +
                           $"name = '{p.Name}', " +
                           $"quantity = {p.Quantity}, " +
                           $"price = {p.Price}, " +
                           $"supplier_id = {(p.SupplierId.HasValue ? p.SupplierId.ToString() : "NULL")} " +
                           $"WHERE sku = '{p.SKU}'";

            return db.ExecuteNonQuery(query);
        }

        public bool DeleteProduct(string sku)
        {
            string query = $"DELETE FROM products WHERE sku = '{sku}'";
            return db.ExecuteNonQuery(query);
        }
    }
}

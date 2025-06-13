using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Repositories
{
    public class SupplierRepository
    {
        private readonly Database db;

        public SupplierRepository()
        {
            db = new Database();
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            string query = "SELECT * FROM suppliers";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    Supplier s = new Supplier
                    {
                        SupplierId = Convert.ToInt32(row["supplier_id"]),
                        SupplierName = row["supplier_name"].ToString(),
                        Phone = row["phone"].ToString(),
                        Email = row["email"].ToString(),
                        Address = row["address"].ToString()
                    };
                    suppliers.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch suppliers: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return suppliers;
        }

        public Supplier GetSupplierById(int id)
        {
            Supplier supplier = null;
            string query = "SELECT * FROM suppliers WHERE supplier_id = @id";

            try
            {
                MySqlConnection conn = db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new Supplier
                    {
                        SupplierId = Convert.ToInt32(reader["supplier_id"]),
                        SupplierName = reader["supplier_name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Email = reader["email"].ToString(),
                        Address = reader["address"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch supplier: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            return supplier;
        }

        public bool AddSupplier(Supplier s)
        {
            string query = "INSERT INTO suppliers (supplier_name, phone, email, address) " +
                           "VALUES (@name, @phone, @email, @address)";

            try
            {
                MySqlConnection conn = db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", s.SupplierName);
                cmd.Parameters.AddWithValue("@phone", s.Phone);
                cmd.Parameters.AddWithValue("@email", s.Email);
                cmd.Parameters.AddWithValue("@address", s.Address);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to add supplier: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdateSupplier(Supplier s)
        {
            string query = "UPDATE suppliers SET supplier_name = @name, phone = @phone, email = @email, address = @address " +
                           "WHERE supplier_id = @id";

            try
            {
                MySqlConnection conn = db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", s.SupplierName);
                cmd.Parameters.AddWithValue("@phone", s.Phone);
                cmd.Parameters.AddWithValue("@email", s.Email);
                cmd.Parameters.AddWithValue("@address", s.Address);
                cmd.Parameters.AddWithValue("@id", s.SupplierId);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to update supplier: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DeleteSupplier(int id)
        {
            string query = "DELETE FROM suppliers WHERE supplier_id = @id";

            try
            {
                MySqlConnection conn = db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to delete supplier: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}

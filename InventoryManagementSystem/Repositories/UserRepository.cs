using System;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Repositories
{
    public class UserRepository
    {
        private readonly Database db;

        public UserRepository()
        {
            db = new Database();
        }

        public User GetUserByUsername(string username)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}'";

            try
            {
                DataTable dt = db.ExecuteQuery(query);
                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    return new User
                    {
                        UserId = Convert.ToInt32(row["user_id"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        Role = row["role"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to fetch user: " + ex.Message, "Repository Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}

using System;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Controllers
{
    public class UserController
    {
        private readonly UserRepository userRepo;

        public UserController()
        {
            userRepo = new UserRepository();
        }

        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            User user = userRepo.GetUserByUsername(username);

            if (user == null)
            {
                MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!VerifyPassword(password, user.Password))
            {
                MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return user; // Caller will pass this to other forms
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            // For demonstration: plaintext comparison
            // Replace with hashed password check if needed
            return inputPassword == storedHash;
        }
    }
}

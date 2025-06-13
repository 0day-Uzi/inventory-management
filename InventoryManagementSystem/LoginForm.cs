using System;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly UserController userController;

        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            User user = userController.Login(username, password);

            if (user != null)
            {
                MainForm main = new MainForm(user); // pass user to MainForm
                main.Show();
                this.Hide();
            }
        }
    }
}

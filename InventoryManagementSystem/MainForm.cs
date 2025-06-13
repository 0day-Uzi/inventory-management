using System;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})";

            // Role-based access
            if (_currentUser.Role == "admin")
            {
                btnProducts.Visible = false;
                btnSuppliers.Visible = false;
                btnOrders.Visible = false;

                btnStockMovements.Visible = true;
                btnLowStockAlerts.Visible = true;
                btnReports.Visible = true;
            }
            else if (_currentUser.Role == "manager")
            {
                btnProducts.Visible = true;
                btnSuppliers.Visible = true;
                btnOrders.Visible = true;

                btnStockMovements.Visible = false;
                btnLowStockAlerts.Visible = false;
                btnReports.Visible = false;
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierListForm form = new SupplierListForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStockMovements_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLowStockAlerts_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            
        }
    }
}

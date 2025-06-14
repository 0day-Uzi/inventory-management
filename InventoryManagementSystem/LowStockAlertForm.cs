using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class LowStockAlertForm : Form
    {
        private LowStockController controller;
        public LowStockAlertForm()
        {
            InitializeComponent();
            controller = new LowStockController();
            LoadAlerts();
            AttachNavigationEvents();
        }

        private void LoadAlerts()
        {
            var alerts = controller.GetAllAlerts();

            var displayList = alerts.Select(a => new
            {
                a.AlertID,
                a.ProductSku,
                a.AlertTime,
                a.CurrentQuantity,
            }).ToList();

            dgvAlerts.DataSource = displayList;

            if (dgvAlerts.Columns["AlertID"] != null)
                dgvAlerts.Columns["AlertID"].HeaderText = "SKU";
            if (dgvAlerts.Columns["ProductSku"] != null)
                dgvAlerts.Columns["ProductSku"].HeaderText = "Name";
            if (dgvAlerts.Columns["AlertTime"] != null)
                dgvAlerts.Columns["AlertTime"].HeaderText = "Qty";
            if (dgvAlerts.Columns["CurrentQuantity"] != null)
                dgvAlerts.Columns["CurrentQuantity"].HeaderText = "Price";
        }

        private void AttachNavigationEvents()
        {

            btnNavMovements.Click += (s, e) =>
            {
                StockMovementForm movementForm = new StockMovementForm();
                movementForm.Show();
                this.Close();
            };

            btnNavAlerts.Click += (s, e) => { };

            btnNavReports.Click += (s, e) =>
            {
                this.Hide();
                ViewReportsForm form = new ViewReportsForm();
                form.Show();
            };

        }
    }
}

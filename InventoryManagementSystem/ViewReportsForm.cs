using System;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class ViewReportsForm : Form
    {
        private readonly ReportController controller;

        public ViewReportsForm()
        {
            InitializeComponent();
            controller = new ReportController();
            AttachEvents();
        }

        private void AttachEvents()
        {
            btnStockTurnover.Click += (s, e) => LoadReport("stock_turnover");
            btnMostOrdered.Click += (s, e) => LoadReport("most_ordered");
            btnSupplierPerformance.Click += (s, e) => LoadReport("supplier_performance");

            btnNavAlerts.Click += (s, e) =>
            {
                LowStockAlertForm alertForm = new LowStockAlertForm();
                alertForm.Show();
                this.Close();
            };

            btnNavMovements.Click += (s, e) =>
            {
                StockMovementForm moveForm = new StockMovementForm();
                moveForm.Show();
                this.Close();
            };

            btnNavReports.Click += (s, e) => { }; // Already on this page
        }

        private void LoadReport(string reportType)
        {
            DataTable report = controller.GenerateReport(reportType);
            dgvReports.DataSource = report;

            // Optional: Rename headers dynamically if needed
            foreach (DataGridViewColumn col in dgvReports.Columns)
            {
                col.HeaderText = col.HeaderText.Replace("_", " ");
            }
        }
    }
}

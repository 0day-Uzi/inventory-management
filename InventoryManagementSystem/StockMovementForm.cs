using InventoryManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class StockMovementForm : Form
    {
        private StockMovementController controller;
        public StockMovementForm()
        {
            InitializeComponent();
            controller = new StockMovementController();
            LoadMovements();
            AttachNavigationEvents();
        }

        private void LoadMovements()
        {
            var movements = controller.GetAllMovements();

            var displayList = movements.Select(m => new
            {
                m.MovementId,
                m.ProductSKU,
                m.MovementType,
                m.QuantityChanged,
                m.MovementTime,
                m.Notes,
            }).ToList();

            dgvMovements.DataSource = displayList;

            if (dgvMovements.Columns["MovementId"] != null)
                dgvMovements.Columns["MovementId"].HeaderText = "Movement ID";
            if (dgvMovements.Columns["ProductSku"] != null)
                dgvMovements.Columns["ProductSku"].HeaderText = "ProductSku";
            if (dgvMovements.Columns["MovementType"] != null)
                dgvMovements.Columns["MovementType"].HeaderText = "Movement Type";
            if (dgvMovements.Columns["QuantityChanged"] != null)
                dgvMovements.Columns["QuantityChanged"].HeaderText = "Quantity Changed";
            if (dgvMovements.Columns["MovementTime"] != null)
                dgvMovements.Columns["MovementTime"].HeaderText = "Movement Time";
            if (dgvMovements.Columns["Notes"] != null)
                dgvMovements.Columns["Notes"].HeaderText = "Notes";
        }

        private void AttachNavigationEvents()
        {

            btnNavAlerts.Click += (s, e) =>
            {
                this.Hide();
                LowStockAlertForm form = new LowStockAlertForm();
                form.Show();
            };

            btnNavMovements.Click += (s, e) => { };

            btnNavReports.Click += (s, e) =>
            {
                this.Hide();
                ViewReportsForm form = new ViewReportsForm();
                form.Show();
            };

        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class OrderForm : Form
    {
        private readonly OrderController controller;
        private readonly SupplierController supplierController;

        public OrderForm()
        {
            InitializeComponent();
            controller = new OrderController();
            supplierController = new SupplierController();
            LoadOrders();
            SetupGridButtons();
            AttachEvents();
        }

        private void LoadOrders()
        {
            var orders = controller.GetAllOrders();
            var suppliers = supplierController.GetAllSuppliers();

            var displayList = orders.Select(o => new
            {
                o.OrderId,
                o.OrderDate,
                Supplier = o.SupplierId.HasValue
                    ? suppliers.FirstOrDefault(s => s.SupplierId == o.SupplierId)?.SupplierName ?? "(Unknown)"
                    : "(None)",
                o.TotalAmount,
                o.OrderStatus
            }).ToList();

            dgvOrders.DataSource = displayList;

            if (dgvOrders.Columns["OrderId"] != null)
                dgvOrders.Columns["OrderId"].HeaderText = "Order ID";
            if (dgvOrders.Columns["OrderDate"] != null)
                dgvOrders.Columns["OrderDate"].HeaderText = "Date";
            if (dgvOrders.Columns["Supplier"] != null)
                dgvOrders.Columns["Supplier"].HeaderText = "Supplier";
            if (dgvOrders.Columns["TotalAmount"] != null)
                dgvOrders.Columns["TotalAmount"].HeaderText = "Total";
            if (dgvOrders.Columns["OrderStatus"] != null)
                dgvOrders.Columns["OrderStatus"].HeaderText = "Status";
        }

        private void SetupGridButtons()
        {
            if (!dgvOrders.Columns.Contains("View") && !dgvOrders.Columns.Contains("Receive"))
            {
                var viewBtn = new DataGridViewButtonColumn
                {
                    Name = "View",
                    HeaderText = "",
                    Text = "View Items",
                    UseColumnTextForButtonValue = true,
                    Width = 100
                };
                dgvOrders.Columns.Add(viewBtn);

                var receiveBtn = new DataGridViewButtonColumn
                {
                    Name = "Receive",
                    HeaderText = "",
                    Text = "Mark Received",
                    UseColumnTextForButtonValue = true,
                    Width = 110
                };
                dgvOrders.Columns.Add(receiveBtn);

                dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvOrders.Rows[e.RowIndex];
            int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);
            string status = row.Cells["OrderStatus"].Value.ToString();
            string columnName = dgvOrders.Columns[e.ColumnIndex].Name;

            if (columnName == "View")
            {
                OrderDetailsForm form = new OrderDetailsForm(orderId);
                form.ShowDialog();
            }
            else if (columnName == "Receive")
            {
                if (status == "received")
                {
                    MessageBox.Show("✅ This order is already marked as received.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to mark this order as received and update stock quantities?",
                    "Confirm Receive", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var items = controller.GetItemsByOrderId(orderId);
                    bool success = controller.ReceiveOrder(items);

                    if (success)
                    {
                        MessageBox.Show("✅ Order marked as received.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("❌ Failed to mark order as received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AttachEvents()
        {
            btnNavProducts.Click += (s, e) =>
            {
                ProductListForm form = new ProductListForm();
                form.Show();
                this.Close();
            };

            btnNavSuppliers.Click += (s, e) =>
            {
                SupplierListForm form = new SupplierListForm();
                form.Show();
                this.Close();
            };

            btnNavOrders.Click += (s, e) => { /* Already here */ };

            btnPlaceOrder.Click += (s, e) =>
            {
                PlaceOrderForm form = new PlaceOrderForm();
                form.FormClosed += (sender, args) => LoadOrders();
                form.ShowDialog();
            };
        }
    }
}

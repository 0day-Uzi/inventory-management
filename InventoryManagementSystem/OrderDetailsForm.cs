using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class OrderDetailsForm : Form
    {
        private readonly int orderId;
        private readonly OrderController controller;
        private readonly ProductController productController;

        public OrderDetailsForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            controller = new OrderController();
            productController = new ProductController();
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            var items = controller.GetItemsByOrderId(orderId);
            var products = productController.GetAllProducts();

            var displayList = items.Select(i => new
            {
                i.ProductSKU,
                ProductName = products.FirstOrDefault(p => p.SKU == i.ProductSKU)?.Name ?? "(Unknown)",
                i.Quantity,
                i.PriceEach,
                Total = i.Quantity * i.PriceEach
            }).ToList();

            dgvItems.DataSource = displayList;

            if (dgvItems.Columns["ProductSKU"] != null)
                dgvItems.Columns["ProductSKU"].HeaderText = "SKU";
            if (dgvItems.Columns["ProductName"] != null)
                dgvItems.Columns["ProductName"].HeaderText = "Product";
            if (dgvItems.Columns["Quantity"] != null)
                dgvItems.Columns["Quantity"].HeaderText = "Qty";
            if (dgvItems.Columns["PriceEach"] != null)
                dgvItems.Columns["PriceEach"].HeaderText = "Unit Price";
            if (dgvItems.Columns["Total"] != null)
                dgvItems.Columns["Total"].HeaderText = "Line Total";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

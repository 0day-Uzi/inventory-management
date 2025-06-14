using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class PlaceOrderForm : Form
    {
        private readonly SupplierController supplierController;
        private readonly ProductController productController;
        private readonly OrderController orderController;

        private List<Product> availableProducts;

        public PlaceOrderForm()
        {
            InitializeComponent();
            supplierController = new SupplierController();
            productController = new ProductController();
            orderController = new OrderController();

            LoadSuppliers();
            cbSuppliers.SelectedIndexChanged += (s, e) => LoadProductsForSupplier();
            btnSubmit.Click += (s, e) => SubmitOrder();
        }

        private void LoadSuppliers()
        {
            var suppliers = supplierController.GetAllSuppliers();
            cbSuppliers.DataSource = suppliers;
            cbSuppliers.DisplayMember = "SupplierName";
            cbSuppliers.ValueMember = "SupplierId";
        }

        private void LoadProductsForSupplier()
        {
            if (cbSuppliers.SelectedValue == null) return;

            int supplierId = Convert.ToInt32(cbSuppliers.SelectedValue);
            availableProducts = productController.GetAllProducts()
                                                 .Where(p => p.SupplierId == supplierId)
                                                 .ToList();

            dgvItems.Columns.Clear();

            var comboCol = new DataGridViewComboBoxColumn
            {
                Name = "Product",
                HeaderText = "Product",
                Width = 250,
                DataSource = availableProducts,
                DisplayMember = "Name",
                ValueMember = "SKU"
            };
            dgvItems.Columns.Add(comboCol);

            dgvItems.Columns.Add("PriceEach", "Unit Price");
            dgvItems.Columns.Add("Quantity", "Qty");

            dgvItems.Columns["PriceEach"].ReadOnly = true;

            dgvItems.CellValueChanged += DgvItems_CellValueChanged;
            dgvItems.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvItems.IsCurrentCellDirty)
                {
                    dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
            dgvItems.RowsRemoved += (s, e) => CalculateTotal();
            dgvItems.UserDeletedRow += (s, e) => CalculateTotal();
        }

        private void DgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvItems.Columns[e.ColumnIndex].Name != "Product") return;

            var row = dgvItems.Rows[e.RowIndex];
            string sku = row.Cells["Product"].Value?.ToString();
            var product = availableProducts.FirstOrDefault(p => p.SKU == sku);
            if (product != null)
            {
                row.Cells["PriceEach"].Value = product.Price.ToString("0.00");
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;

                bool qtyParsed = int.TryParse(Convert.ToString(row.Cells["Quantity"].Value), out int qty);
                bool priceParsed = decimal.TryParse(Convert.ToString(row.Cells["PriceEach"].Value), out decimal price);

                if (qtyParsed && priceParsed)
                {
                    total += qty * price;
                }
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void SubmitOrder()
        {
            if (cbSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<OrderItem> items = new List<OrderItem>();

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;

                string sku = Convert.ToString(row.Cells["Product"].Value);
                bool qtyParsed = int.TryParse(Convert.ToString(row.Cells["Quantity"].Value), out int qty);
                bool priceParsed = decimal.TryParse(Convert.ToString(row.Cells["PriceEach"].Value), out decimal price);

                if (string.IsNullOrWhiteSpace(sku) || !qtyParsed || !priceParsed || qty <= 0)
                {
                    MessageBox.Show("Invalid row entry. Please check all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                items.Add(new OrderItem
                {
                    ProductSKU = sku,
                    Quantity = qty,
                    PriceEach = price
                });
            }

            var selectedSupplier = (Supplier)cbSuppliers.SelectedItem;
            Order order = new Order
            {
                SupplierId = selectedSupplier.SupplierId,
                OrderStatus = "placed"
            };

            bool success = orderController.PlaceOrder(order, items);
            if (success) this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

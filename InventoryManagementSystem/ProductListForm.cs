using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class ProductListForm : Form
    {
        private ProductController controller;

        public ProductListForm()
        {
            InitializeComponent();
            controller = new ProductController();
            LoadProductData();
            SetupGridActions();
            AttachNavigationEvents();
        }

        private void LoadProductData()
        {
            var products = controller.GetAllProducts();
            var suppliers = new SupplierController().GetAllSuppliers();

            var displayList = products.Select(p => new
            {
                p.SKU,
                p.Name,
                p.Quantity,
                p.Price,
                Supplier = p.SupplierId.HasValue
                    ? suppliers.FirstOrDefault(s => s.SupplierId == p.SupplierId)?.SupplierName ?? "(Unknown)"
                    : "(None)"
            }).ToList();

            dgvProducts.DataSource = displayList;

            if (dgvProducts.Columns["SKU"] != null)
                dgvProducts.Columns["SKU"].HeaderText = "SKU";
            if (dgvProducts.Columns["Name"] != null)
                dgvProducts.Columns["Name"].HeaderText = "Name";
            if (dgvProducts.Columns["Quantity"] != null)
                dgvProducts.Columns["Quantity"].HeaderText = "Qty";
            if (dgvProducts.Columns["Price"] != null)
                dgvProducts.Columns["Price"].HeaderText = "Price";
            if (dgvProducts.Columns["Supplier"] != null)
                dgvProducts.Columns["Supplier"].HeaderText = "Supplier";
        }

        private void SetupGridActions()
        {
            // Avoid duplication
            if (!dgvProducts.Columns.Contains("Edit") && !dgvProducts.Columns.Contains("Delete"))
            {
                var editBtn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "✏️",
                    UseColumnTextForButtonValue = true,
                    Width = 40
                };
                dgvProducts.Columns.Add(editBtn);

                var deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "🗑️",
                    UseColumnTextForButtonValue = true,
                    Width = 40
                };
                dgvProducts.Columns.Add(deleteBtn);

                var assignBtn = new DataGridViewButtonColumn
                {
                    Name = "Assign",
                    HeaderText = "",
                    Text = "🔗",
                    UseColumnTextForButtonValue = true,
                    Width = 40
                };
                dgvProducts.Columns.Add(assignBtn);

                dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProducts.Rows[e.RowIndex];
            string sku = row.Cells["SKU"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();

            string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                EditProductForm editForm = new EditProductForm(sku);
                editForm.FormClosed += (s, args) => LoadProductData();
                editForm.ShowDialog();
            }
            else if (columnName == "Delete")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete product '{name}' (SKU: {sku})?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (controller.DeleteProduct(sku))
                    {
                        MessageBox.Show("✅ Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("❌ Failed to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (columnName == "Assign")
            {
                AssignSupplierForm assignForm = new AssignSupplierForm(sku);
                assignForm.FormClosed += (s, args) => LoadProductData();
                assignForm.ShowDialog();
            }
        }

        private void AttachNavigationEvents()
        {

            btnNavSuppliers.Click += (s, e) =>
            {
                SupplierListForm supplierForm = new SupplierListForm();
                supplierForm.Show();
                this.Close();
            };

            btnNavProducts.Click += (s, e) => { /* Already on this page */ };

            btnNavAddProduct.Click += (s, e) =>
            {
                AddProductForm addProduct = new AddProductForm();
                addProduct.FormClosed += (sender, args) => LoadProductData();
                addProduct.ShowDialog();
            };

            btnNavOrders.Click += (s, e) =>
            {
                OrderForm form = new OrderForm(); 
                form.Show();
                this.Close();
            };

        }
    }
}

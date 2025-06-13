using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class AddProductForm : Form
    {
        private readonly ProductController productController;
        private readonly SupplierController supplierController;

        public AddProductForm()
        {
            InitializeComponent();
            productController = new ProductController();
            supplierController = new SupplierController();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = supplierController.GetAllSuppliers();
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSKU.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product product = new Product
            {
                SKU = txtSKU.Text.Trim(),
                Name = txtName.Text.Trim(),
                Quantity = quantity,
                Price = price,
                SupplierId = cmbSupplier.SelectedIndex >= 0 ? (int?)cmbSupplier.SelectedValue : null
            };

            if (productController.AddProduct(product))
            {
                MessageBox.Show("✅ Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Triggers FormClosed in ProductListForm
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Xml.Linq;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class EditProductForm : Form
    {
        private string sku;
        private ProductController productController;
        private SupplierController supplierController;

        public EditProductForm(string sku)
        {
            InitializeComponent();
            this.sku = sku;
            productController = new ProductController();
            supplierController = new SupplierController();
            LoadProductData();
        }

        private void LoadProductData()
        {
            Product product = productController.GetProductBySKU(sku);
            if (product == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtSKU.Text = product.SKU;
            txtName.Text = product.Name;
            txtQuantity.Text = product.Quantity.ToString();
            txtPrice.Text = product.Price.ToString("0.00");

            cmbSupplier.DataSource = supplierController.GetAllSuppliers();
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.SelectedIndex = product.SupplierId.HasValue ?
                cmbSupplier.FindStringExact(product.SupplierId.ToString()) : -1;
            if (product.SupplierId.HasValue)
                cmbSupplier.SelectedValue = product.SupplierId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product updatedProduct = new Product
            {
                SKU = txtSKU.Text.Trim(),
                Name = txtName.Text.Trim(),
                Quantity = quantity,
                Price = price,
                SupplierId = cmbSupplier.SelectedIndex >= 0 ? (int?)cmbSupplier.SelectedValue : null
            };

            bool success = productController.UpdateProduct(updatedProduct);
            if (success)
            {
                MessageBox.Show("✅ Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // Controller will handle error message
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

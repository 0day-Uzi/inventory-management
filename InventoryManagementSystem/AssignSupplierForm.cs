using System;
using System.Windows.Forms;
using System.Xml.Linq;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class AssignSupplierForm : Form
    {
        private readonly string sku;
        private readonly ProductController productController;
        private readonly SupplierController supplierController;
        private Product product;

        public AssignSupplierForm(string sku)
        {
            InitializeComponent();
            this.sku = sku;
            productController = new ProductController();
            supplierController = new SupplierController();
            LoadProduct();
        }

        private void LoadProduct()
        {
            product = productController.GetProductBySKU(sku);
            if (product == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Fill read-only product info
            txtSKU.Text = product.SKU;
            txtName.Text = product.Name;
            txtQuantity.Text = product.Quantity.ToString();
            txtPrice.Text = product.Price.ToString("0.00");

            // Load supplier list
            cmbSupplier.DataSource = supplierController.GetAllSuppliers();
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.SelectedValue = product.SupplierId ?? -1;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            product.SupplierId = (int)cmbSupplier.SelectedValue;

            if (productController.UpdateProduct(product))
            {
                MessageBox.Show("✅ Supplier assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            // Controller handles error display
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

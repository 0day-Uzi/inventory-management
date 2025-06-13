using System;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class AddSupplierForm : Form
    {
        private readonly SupplierController supplierController;

        public AddSupplierForm()
        {
            InitializeComponent();
            supplierController = new SupplierController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                SupplierName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (supplierController.AddSupplier(supplier))
            {
                MessageBox.Show("✅ Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // This will trigger FormClosed in SupplierListForm
            }
        }
    }
}

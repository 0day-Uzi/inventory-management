using System;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem
{
    public partial class EditSupplierForm : Form
    {
        private int supplierId;
        private SupplierController controller;

        public EditSupplierForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            controller = new SupplierController();
            LoadSupplierData();
        }

        private void LoadSupplierData()
        {
            Supplier supplier = controller.GetSupplierById(supplierId);
            if (supplier == null)
            {
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = supplier.SupplierName;
            txtPhone.Text = supplier.Phone;
            txtEmail.Text = supplier.Email;
            txtAddress.Text = supplier.Address;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier updatedSupplier = new Supplier
            {
                SupplierId = supplierId,
                SupplierName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            bool success = controller.UpdateSupplier(updatedSupplier);
            if (success)
            {
                MessageBox.Show("✅ Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Error messages are already shown from the controller
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class SupplierListForm : Form
    {
        private SupplierController controller;

        public SupplierListForm()
        {
            InitializeComponent();
            controller = new SupplierController();
            LoadSupplierData();
            SetupGridActions();
            AttachNavigationEvents();
        }

        private void LoadSupplierData()
        {
            dgvSuppliers.DataSource = controller.GetAllSuppliers();

            // Hide SupplierId for cleaner view
            if (dgvSuppliers.Columns["SupplierId"] != null)
                dgvSuppliers.Columns["SupplierId"].Visible = false;

            dgvSuppliers.Columns["SupplierName"].HeaderText = "Name";
            dgvSuppliers.Columns["Phone"].HeaderText = "Phone";
            dgvSuppliers.Columns["Email"].HeaderText = "Email";
            dgvSuppliers.Columns["Address"].HeaderText = "Address";
        }

        private void SetupGridActions()
        {
            // Prevent adding duplicates
            if (!dgvSuppliers.Columns.Contains("Edit") && !dgvSuppliers.Columns.Contains("Delete"))
            {
                var editBtn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "✏️",
                    UseColumnTextForButtonValue = true,
                    Width = 40
                };
                dgvSuppliers.Columns.Add(editBtn);

                var deleteBtn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "🗑️",
                    UseColumnTextForButtonValue = true,
                    Width = 40
                };
                dgvSuppliers.Columns.Add(deleteBtn);

                dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            }
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSuppliers.Rows[e.RowIndex];
            int supplierId = Convert.ToInt32(row.Cells["SupplierId"].Value);
            string supplierName = row.Cells["SupplierName"].Value.ToString();

            if (dgvSuppliers.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditSupplierForm editForm = new EditSupplierForm(supplierId);
                editForm.FormClosed += (s, args) => LoadSupplierData();
                editForm.ShowDialog();
            }
            else if (dgvSuppliers.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete supplier '{supplierName}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (controller.DeleteSupplier(supplierId))
                    {
                        MessageBox.Show("✅ Supplier deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierData();
                    }
                    else
                    {
                        MessageBox.Show("❌ Failed to delete the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AttachNavigationEvents()
        {

            btnNavProducts.Click += (s, e) =>
            {
                ProductListForm productForm = new ProductListForm();
                productForm.Show();
                this.Close();
            };

            btnNavAddSupplier.Click += (s, e) =>
            {
                AddSupplierForm addSupplier = new AddSupplierForm();
                addSupplier.FormClosed += (sender, args) => LoadSupplierData();
                addSupplier.ShowDialog();
            };

            btnNavOrders.Click += (s, e) =>
            {
                OrderForm form = new OrderForm(); 
                form.Show();
                this.Close();
            };


            // Current section (Suppliers) – no action
            btnNavSuppliers.Click += (s, e) => { };
        }
    }
}

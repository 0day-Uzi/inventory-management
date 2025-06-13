namespace InventoryManagementSystem
{
    partial class SupplierListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavSuppliers;
        private System.Windows.Forms.Button btnNavAddSupplier;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.DataGridView dgvSuppliers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavSuppliers = new System.Windows.Forms.Button();
            this.btnNavAddSupplier = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 160;
            this.panelLeft.Controls.Add(this.btnNavOrders);
            this.panelLeft.Controls.Add(this.btnNavAddSupplier);
            this.panelLeft.Controls.Add(this.btnNavSuppliers);
            this.panelLeft.Controls.Add(this.btnNavProducts);



            // 
            // btnNavProducts
            // 
            this.btnNavProducts.Text = "Products";
            this.btnNavProducts.Size = new System.Drawing.Size(140, 30);
            this.btnNavProducts.Location = new System.Drawing.Point(10, 60);

            // 
            // btnNavSuppliers
            // 
            this.btnNavSuppliers.Text = "Suppliers";
            this.btnNavSuppliers.Size = new System.Drawing.Size(140, 30);
            this.btnNavSuppliers.Location = new System.Drawing.Point(10, 100);

            // 
            // btnNavAddSupplier
            // 
            this.btnNavAddSupplier.Text = "Add Supplier";
            this.btnNavAddSupplier.Size = new System.Drawing.Size(140, 30);
            this.btnNavAddSupplier.Location = new System.Drawing.Point(10, 140);

            // 
            // btnNavOrders
            // 
            this.btnNavOrders.Text = "Orders";
            this.btnNavOrders.Size = new System.Drawing.Size(140, 30);
            this.btnNavOrders.Location = new System.Drawing.Point(10, 180);

            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Controls.Add(this.dgvSuppliers);
            this.panelRight.BackColor = System.Drawing.SystemColors.Window;

            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.Window;

            // 
            // SupplierListForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SupplierListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";

            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

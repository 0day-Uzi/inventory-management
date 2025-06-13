namespace InventoryManagementSystem
{
    partial class ProductListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavAddProduct;
        private System.Windows.Forms.Button btnNavSuppliers;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavAddProduct = new System.Windows.Forms.Button();
            this.btnNavSuppliers = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button(); // 💡 Move this up here

            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 160;
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.btnNavOrders);
            this.panelLeft.Controls.Add(this.btnNavSuppliers);
            this.panelLeft.Controls.Add(this.btnNavAddProduct);
            this.panelLeft.Controls.Add(this.btnNavProducts);

            // 
            // btnNavProducts
            // 
            this.btnNavProducts.Text = "Products";
            this.btnNavProducts.Size = new System.Drawing.Size(140, 30);
            this.btnNavProducts.Location = new System.Drawing.Point(10, 60);

            // 
            // btnNavAddProduct
            // 
            this.btnNavAddProduct.Text = "Add Product";
            this.btnNavAddProduct.Size = new System.Drawing.Size(140, 30);
            this.btnNavAddProduct.Location = new System.Drawing.Point(10, 100);

            // 
            // btnNavSuppliers
            // 
            this.btnNavSuppliers.Text = "Suppliers";
            this.btnNavSuppliers.Size = new System.Drawing.Size(140, 30);
            this.btnNavSuppliers.Location = new System.Drawing.Point(10, 140);

            // 
            // btnNavOrders
            // 
            this.btnNavOrders.Text = "Orders";
            this.btnNavOrders.Size = new System.Drawing.Size(140, 30);
            this.btnNavOrders.Location = new System.Drawing.Point(10, 180); // ✅ Now visible

            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.BackColor = System.Drawing.SystemColors.Window;
            this.panelRight.Controls.Add(this.dgvProducts);

            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;

            // 
            // ProductListForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";

            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

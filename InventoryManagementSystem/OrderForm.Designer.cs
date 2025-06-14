namespace InventoryManagementSystem
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavSuppliers;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvOrders;

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
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();

            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();

            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 160;
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.btnPlaceOrder);
            this.panelLeft.Controls.Add(this.btnNavOrders);
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
            // btnNavOrders
            // 
            this.btnNavOrders.Text = "Orders";
            this.btnNavOrders.Size = new System.Drawing.Size(140, 30);
            this.btnNavOrders.Location = new System.Drawing.Point(10, 140);

            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Text = "Place New Order";
            this.btnPlaceOrder.Size = new System.Drawing.Size(140, 30);
            this.btnPlaceOrder.Location = new System.Drawing.Point(10, 180);

            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.BackColor = System.Drawing.SystemColors.Window;
            this.panelRight.Controls.Add(this.dgvOrders);

            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Window;

            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";

            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

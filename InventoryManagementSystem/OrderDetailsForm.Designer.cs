namespace InventoryManagementSystem
{
    partial class OrderDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Order Details";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);

            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItems.Location = new System.Drawing.Point(20, 60);
            this.dgvItems.Size = new System.Drawing.Size(540, 280);

            // 
            // btnClose
            // 
            this.btnClose.Text = "Close";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.Location = new System.Drawing.Point(480, 360);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // OrderDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Details";

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

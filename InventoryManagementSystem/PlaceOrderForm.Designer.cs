namespace InventoryManagementSystem
{
    partial class PlaceOrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // lblSupplier
            this.lblSupplier.Text = "Select Supplier:";
            this.lblSupplier.Location = new System.Drawing.Point(20, 20);
            this.lblSupplier.AutoSize = true;

            // cbSuppliers
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.Location = new System.Drawing.Point(130, 17);
            this.cbSuppliers.Size = new System.Drawing.Size(250, 25);

            // dgvItems
            this.dgvItems.Location = new System.Drawing.Point(20, 60);
            this.dgvItems.Size = new System.Drawing.Size(640, 250);
            this.dgvItems.AllowUserToAddRows = true;
            this.dgvItems.AllowUserToDeleteRows = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window;

            // lblTotal
            this.lblTotal.Text = "Total:";
            this.lblTotal.Location = new System.Drawing.Point(20, 330);
            this.lblTotal.AutoSize = true;

            // txtTotal
            this.txtTotal.Location = new System.Drawing.Point(70, 327);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Width = 100;

            // btnSubmit
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.Location = new System.Drawing.Point(460, 320);
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(570, 320);
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // PlaceOrderForm
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PlaceOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Place New Order";

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

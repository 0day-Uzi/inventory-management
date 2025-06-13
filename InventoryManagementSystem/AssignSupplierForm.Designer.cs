namespace InventoryManagementSystem
{
    partial class AssignSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;

        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbSupplier;

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Drawing.Font fontDefault = new System.Drawing.Font("Segoe UI", 10F);

            this.lblSKU = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();

            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();

            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 30, inputX = 140, topY = 20, spacingY = 40, inputWidth = 250;

            // lblSKU
            this.lblSKU.Text = "SKU:";
            this.lblSKU.Font = fontDefault;
            this.lblSKU.Location = new System.Drawing.Point(labelX, topY);

            this.txtSKU.Font = fontDefault;
            this.txtSKU.Location = new System.Drawing.Point(inputX, topY);
            this.txtSKU.Width = inputWidth;
            this.txtSKU.ReadOnly = true;

            // lblName
            this.lblName.Text = "Name:";
            this.lblName.Font = fontDefault;
            this.lblName.Location = new System.Drawing.Point(labelX, topY + spacingY);

            this.txtName.Font = fontDefault;
            this.txtName.Location = new System.Drawing.Point(inputX, topY + spacingY);
            this.txtName.Width = inputWidth;
            this.txtName.ReadOnly = true;

            // lblQuantity
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Font = fontDefault;
            this.lblQuantity.Location = new System.Drawing.Point(labelX, topY + spacingY * 2);

            this.txtQuantity.Font = fontDefault;
            this.txtQuantity.Location = new System.Drawing.Point(inputX, topY + spacingY * 2);
            this.txtQuantity.Width = inputWidth;
            this.txtQuantity.ReadOnly = true;

            // lblPrice
            this.lblPrice.Text = "Price:";
            this.lblPrice.Font = fontDefault;
            this.lblPrice.Location = new System.Drawing.Point(labelX, topY + spacingY * 3);

            this.txtPrice.Font = fontDefault;
            this.txtPrice.Location = new System.Drawing.Point(inputX, topY + spacingY * 3);
            this.txtPrice.Width = inputWidth;
            this.txtPrice.ReadOnly = true;

            // lblSupplier
            this.lblSupplier.Text = "Assign Supplier:";
            this.lblSupplier.Font = fontDefault;
            this.lblSupplier.Location = new System.Drawing.Point(labelX, topY + spacingY * 4);

            this.cmbSupplier.Font = fontDefault;
            this.cmbSupplier.Location = new System.Drawing.Point(inputX, topY + spacingY * 4);
            this.cmbSupplier.Width = inputWidth;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnAssign
            this.btnAssign.Text = "✔ Assign";
            this.btnAssign.Font = fontDefault;
            this.btnAssign.Size = new System.Drawing.Size(120, 35);
            this.btnAssign.Location = new System.Drawing.Point(inputX, topY + spacingY * 5 + 10);
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = fontDefault;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(inputX + 140, topY + spacingY * 5 + 10);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AssignSupplierForm
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Supplier to Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace InventoryManagementSystem
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Drawing.Font fontDefault = new System.Drawing.Font("Segoe UI", 10F);

            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 30;
            int inputX = 130;
            int inputWidth = 260;
            int topMargin = 60;
            int spacingY = 45;

            // lblTitle
            this.lblTitle.Text = "Edit Product";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(140, 15);

            // lblSKU
            this.lblSKU.Text = "SKU:";
            this.lblSKU.Font = fontDefault;
            this.lblSKU.Location = new System.Drawing.Point(labelX, topMargin);

            this.txtSKU.Font = fontDefault;
            this.txtSKU.Location = new System.Drawing.Point(inputX, topMargin);
            this.txtSKU.Width = inputWidth;
            this.txtSKU.ReadOnly = true;

            // lblName
            this.lblName.Text = "Name:";
            this.lblName.Font = fontDefault;
            this.lblName.Location = new System.Drawing.Point(labelX, topMargin + spacingY);

            this.txtName.Font = fontDefault;
            this.txtName.Location = new System.Drawing.Point(inputX, topMargin + spacingY);
            this.txtName.Width = inputWidth;

            // lblQuantity
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Font = fontDefault;
            this.lblQuantity.Location = new System.Drawing.Point(labelX, topMargin + spacingY * 2);

            this.txtQuantity.Font = fontDefault;
            this.txtQuantity.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 2);
            this.txtQuantity.Width = inputWidth;

            // lblPrice
            this.lblPrice.Text = "Price:";
            this.lblPrice.Font = fontDefault;
            this.lblPrice.Location = new System.Drawing.Point(labelX, topMargin + spacingY * 3);

            this.txtPrice.Font = fontDefault;
            this.txtPrice.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 3);
            this.txtPrice.Width = inputWidth;

            // lblSupplier
            this.lblSupplier.Text = "Supplier:";
            this.lblSupplier.Font = fontDefault;
            this.lblSupplier.Location = new System.Drawing.Point(labelX, topMargin + spacingY * 4);

            this.cmbSupplier.Font = fontDefault;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 4);
            this.cmbSupplier.Width = inputWidth;

            // btnSave
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = fontDefault;
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 5 + 5);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = fontDefault;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(inputX + 140, topMargin + spacingY * 5 + 5);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // EditProductForm
            this.ClientSize = new System.Drawing.Size(460, 370);
            this.Controls.Add(this.lblTitle);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

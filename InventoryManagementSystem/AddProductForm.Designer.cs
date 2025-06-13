namespace InventoryManagementSystem
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnAdd;
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
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 30;
            int inputX = 130;
            int inputWidth = 260;
            int topMargin = 20;
            int spacingY = 45;

            // lblSKU
            this.lblSKU.Text = "SKU:";
            this.lblSKU.Font = fontDefault;
            this.lblSKU.Location = new System.Drawing.Point(labelX, topMargin);

            this.txtSKU.Font = fontDefault;
            this.txtSKU.Location = new System.Drawing.Point(inputX, topMargin);
            this.txtSKU.Width = inputWidth;

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

            // btnAdd
            this.btnAdd.Text = "➕ Add Product";
            this.btnAdd.Font = fontDefault;
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 5 + 5);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = fontDefault;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(inputX + 150, topMargin + spacingY * 5 + 5);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddProductForm
            this.ClientSize = new System.Drawing.Size(460, 340);
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
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

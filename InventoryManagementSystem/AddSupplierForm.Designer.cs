namespace InventoryManagementSystem
{
    partial class AddSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Drawing.Font defaultFont = new System.Drawing.Font("Segoe UI", 10F);

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Shared layout settings
            int labelX = 30;
            int inputX = 130;
            int inputWidth = 260;
            int spacingY = 45;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(labelX, 25);
            this.lblName.Text = "Name:";
            this.lblName.Font = defaultFont;

            // txtName
            this.txtName.Location = new System.Drawing.Point(inputX, 22);
            this.txtName.Width = inputWidth;
            this.txtName.Font = defaultFont;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(labelX, 25 + spacingY * 1);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = defaultFont;

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(inputX, 22 + spacingY * 1);
            this.txtPhone.Width = inputWidth;
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Font = defaultFont;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(labelX, 25 + spacingY * 2);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = defaultFont;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(inputX, 22 + spacingY * 2);
            this.txtEmail.Width = inputWidth;
            this.txtEmail.Font = defaultFont;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(labelX, 25 + spacingY * 3);
            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = defaultFont;

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(inputX, 22 + spacingY * 3);
            this.txtAddress.Width = inputWidth;
            this.txtAddress.Font = defaultFont;

            // btnAdd
            this.btnAdd.Text = "➕ Add Supplier";
            this.btnAdd.Font = defaultFont;
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.Location = new System.Drawing.Point(inputX, 25 + spacingY * 4);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = defaultFont;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(inputX + 150, 25 + spacingY * 4);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddSupplierForm
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

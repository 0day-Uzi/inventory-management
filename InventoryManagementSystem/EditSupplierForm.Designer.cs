namespace InventoryManagementSystem
{
    partial class EditSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "✏️ Edit Supplier";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.AutoSize = true;

            // Common settings
            int labelX = 30;
            int inputX = 130;
            int inputWidth = 260;
            int topMargin = 60;
            int spacingY = 45;

            // Name
            this.lblName.Text = "Name:";
            this.lblName.Font = fontDefault;
            this.lblName.Location = new System.Drawing.Point(labelX, topMargin);

            this.txtName.Font = fontDefault;
            this.txtName.Location = new System.Drawing.Point(inputX, topMargin);
            this.txtName.Width = inputWidth;

            // Phone
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = fontDefault;
            this.lblPhone.Location = new System.Drawing.Point(labelX, topMargin + spacingY);

            this.txtPhone.Font = fontDefault;
            this.txtPhone.Location = new System.Drawing.Point(inputX, topMargin + spacingY);
            this.txtPhone.Width = inputWidth;

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = fontDefault;
            this.lblEmail.Location = new System.Drawing.Point(labelX, topMargin + spacingY * 2);

            this.txtEmail.Font = fontDefault;
            this.txtEmail.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 2);
            this.txtEmail.Width = inputWidth;

            // Address
            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = fontDefault;
            this.lblAddress.Location = new System.Drawing.Point(labelX, topMargin + spacingY * 3);

            this.txtAddress.Font = fontDefault;
            this.txtAddress.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 3);
            this.txtAddress.Width = inputWidth;

            // Save Button
            this.btnSave.Text = "💾 Save";
            this.btnSave.Font = fontDefault;
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.Location = new System.Drawing.Point(inputX, topMargin + spacingY * 4 + 10);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Cancel Button
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = fontDefault;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(inputX + 150, topMargin + spacingY * 4 + 10);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // EditSupplierForm
            this.ClientSize = new System.Drawing.Size(460, 310);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

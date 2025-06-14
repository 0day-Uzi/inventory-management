namespace InventoryManagementSystem
{
    partial class LowStockAlertForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnNavAlerts;
        private System.Windows.Forms.Button btnNavMovements;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.DataGridView dgvAlerts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnNavAlerts = new System.Windows.Forms.Button();
            this.btnNavMovements = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button(); // 💡 Move this up here

            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            this.SuspendLayout();

            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 160;
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.btnNavReports);
            this.panelLeft.Controls.Add(this.btnNavMovements);
            this.panelLeft.Controls.Add(this.btnNavAlerts);

            // 
            // btnNavAlerts
            // 
            this.btnNavAlerts.Text = "Alerts";
            this.btnNavAlerts.Size = new System.Drawing.Size(140, 30);
            this.btnNavAlerts.Location = new System.Drawing.Point(10, 60);

            // 
            // btnNavMovements
            // 
            this.btnNavMovements.Text = "Track Movements";
            this.btnNavMovements.Size = new System.Drawing.Size(140, 30);
            this.btnNavMovements.Location = new System.Drawing.Point(10, 100);

            // 
            // btnNavMovements
            // 
            this.btnNavReports.Text = "Orders";
            this.btnNavReports.Size = new System.Drawing.Size(140, 30);
            this.btnNavReports.Location = new System.Drawing.Point(10, 140);

            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.BackColor = System.Drawing.SystemColors.Window;
            this.panelRight.Controls.Add(this.dgvAlerts);

            // 
            // dgvAlerts
            // 
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.AllowUserToDeleteRows = false;
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlerts.BackgroundColor = System.Drawing.SystemColors.Window;

            // 
            // AlertListForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlertsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerts";

            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

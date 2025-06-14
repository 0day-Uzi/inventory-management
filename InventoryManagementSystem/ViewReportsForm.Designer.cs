namespace InventoryManagementSystem
{
    partial class ViewReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnNavAlerts;
        private System.Windows.Forms.Button btnNavMovements;
        private System.Windows.Forms.Button btnNavReports;

        private System.Windows.Forms.Button btnStockTurnover;
        private System.Windows.Forms.Button btnMostOrdered;
        private System.Windows.Forms.Button btnSupplierPerformance;

        private System.Windows.Forms.DataGridView dgvReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavMovements = new System.Windows.Forms.Button();
            this.btnNavAlerts = new System.Windows.Forms.Button();

            this.panelRight = new System.Windows.Forms.Panel();
            this.btnStockTurnover = new System.Windows.Forms.Button();
            this.btnMostOrdered = new System.Windows.Forms.Button();
            this.btnSupplierPerformance = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();

            // panelLeft
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 160;
            this.panelLeft.Controls.Add(this.btnNavReports);
            this.panelLeft.Controls.Add(this.btnNavMovements);
            this.panelLeft.Controls.Add(this.btnNavAlerts);

            this.btnNavAlerts.Text = "Alerts";
            this.btnNavAlerts.Size = new System.Drawing.Size(140, 30);
            this.btnNavAlerts.Location = new System.Drawing.Point(10, 60);

            this.btnNavMovements.Text = "Track Movements";
            this.btnNavMovements.Size = new System.Drawing.Size(140, 30);
            this.btnNavMovements.Location = new System.Drawing.Point(10, 100);

            this.btnNavReports.Text = "Reports";
            this.btnNavReports.Size = new System.Drawing.Size(140, 30);
            this.btnNavReports.Location = new System.Drawing.Point(10, 140);

            // panelRight
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Controls.Add(this.dgvReports);
            this.panelRight.Controls.Add(this.btnSupplierPerformance);
            this.panelRight.Controls.Add(this.btnMostOrdered);
            this.panelRight.Controls.Add(this.btnStockTurnover);

            // Top Buttons
            this.btnStockTurnover.Text = "Stock Turnover";
            this.btnStockTurnover.Size = new System.Drawing.Size(160, 30);
            this.btnStockTurnover.Location = new System.Drawing.Point(20, 10);

            this.btnMostOrdered.Text = "Most Ordered";
            this.btnMostOrdered.Size = new System.Drawing.Size(160, 30);
            this.btnMostOrdered.Location = new System.Drawing.Point(200, 10);

            this.btnSupplierPerformance.Text = "Supplier Performance";
            this.btnSupplierPerformance.Size = new System.Drawing.Size(160, 30);
            this.btnSupplierPerformance.Location = new System.Drawing.Point(380, 10);

            // DataGridView
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.ReadOnly = true;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReports.Height = 400;
            this.dgvReports.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";

            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

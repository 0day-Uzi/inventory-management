namespace InventoryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStockMovements;
        private System.Windows.Forms.Button btnLowStockAlerts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.TableLayoutPanel layout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStockMovements = new System.Windows.Forms.Button();
            this.btnLowStockAlerts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.TableLayoutPanel();

            this.layout.SuspendLayout();
            this.SuspendLayout();

            // layout
            this.layout.ColumnCount = 1;
            this.layout.RowCount = 6;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            for (int i = 0; i < 6; i++)
                this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));

            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(420, 400);
            this.layout.TabIndex = 0;

            // lblWelcome
            this.lblWelcome.Text = "Welcome, user";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTitle
            this.lblTitle.Text = "Inventory Management System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- MANAGER BUTTONS ---

            // btnSuppliers
            this.btnSuppliers.Text = "📄 Manage Suppliers";
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuppliers.Size = new System.Drawing.Size(220, 35);
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);

            // btnProducts
            this.btnProducts.Text = "📦 Manage Products";
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProducts.Size = new System.Drawing.Size(220, 35);
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

            // btnOrders
            this.btnOrders.Text = "📥 Place/Receive Orders";
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrders.Size = new System.Drawing.Size(220, 35);
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);

            // --- ADMIN BUTTONS ---

            // btnStockMovements
            this.btnStockMovements.Text = "🔄 Stock Movements";
            this.btnStockMovements.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnStockMovements.ForeColor = System.Drawing.Color.White;
            this.btnStockMovements.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnStockMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovements.FlatAppearance.BorderSize = 0;
            this.btnStockMovements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockMovements.Size = new System.Drawing.Size(220, 35);
            this.btnStockMovements.Click += new System.EventHandler(this.btnStockMovements_Click);

            // btnLowStockAlerts
            this.btnLowStockAlerts.Text = "⚠️ Low Stock Alerts";
            this.btnLowStockAlerts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLowStockAlerts.ForeColor = System.Drawing.Color.White;
            this.btnLowStockAlerts.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnLowStockAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStockAlerts.FlatAppearance.BorderSize = 0;
            this.btnLowStockAlerts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLowStockAlerts.Size = new System.Drawing.Size(220, 35);
            this.btnLowStockAlerts.Click += new System.EventHandler(this.btnLowStockAlerts_Click);

            // btnReports
            this.btnReports.Text = "📊 View Reports";
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Size = new System.Drawing.Size(220, 35);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // Add controls to layout
            this.layout.Controls.Add(this.lblWelcome, 0, 0);
            this.layout.Controls.Add(this.lblTitle, 0, 1);

            // Reserve rows 2–4 for action buttons
            this.layout.Controls.Add(this.btnSuppliers, 0, 2);
            this.layout.Controls.Add(this.btnProducts, 0, 3);
            this.layout.Controls.Add(this.btnOrders, 0, 4);

            this.layout.Controls.Add(this.btnStockMovements, 0, 2);
            this.layout.Controls.Add(this.btnLowStockAlerts, 0, 3);
            this.layout.Controls.Add(this.btnReports, 0, 4);

            // MainForm settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Dashboard";
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

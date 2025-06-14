using System;
using System.Data;
using System.Windows.Forms;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class ReportController
    {
        public DataTable GenerateReport(string reportType)
        {
            IReportGenerator report;

            switch (reportType.ToLower())
            {
                case "stock_turnover":
                    report = new StockTurnoverReport();
                    break;

                case "most_ordered":
                    report = new MostOrderedProductsReport();
                    break;

                case "supplier_performance":
                    report = new SupplierPerformanceReport();
                    break;

                default:
                    MessageBox.Show("⚠️ Invalid report type provided.", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new DataTable(); // Return empty table
            }

            try
            {
                return report.GenerateReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to generate report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
    }
}

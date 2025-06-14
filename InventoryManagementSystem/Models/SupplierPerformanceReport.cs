using System.Data;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Models
{
    public class SupplierPerformanceReport : IReportGenerator
    {
        public DataTable GenerateReport()
        {
            ReportsRepository repo = new ReportsRepository();
            return repo.GetSupplierPerformanceReport();
        }
    }
}

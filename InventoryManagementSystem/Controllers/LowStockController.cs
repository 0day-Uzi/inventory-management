using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Controllers
{
    public class LowStockController
    {

        private readonly LowStockAlertRepository lowStockAlertRepository;

        public LowStockController()
        {
            lowStockAlertRepository = new LowStockAlertRepository();
        }

        public List<LowStockAlert> GetAllAlerts()
        {
            return lowStockAlertRepository.GetAllAlerts();
        }
    }
}

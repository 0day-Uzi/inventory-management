using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class LowStockAlert
    {
        public int AlertID { get; set; }
        public string ProductSku { get; set; }
        public DateTime AlertTime { get; set; }
        public int CurrentQuantity { get; set; }
    }
}

using System;

namespace InventoryManagementSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? SupplierId { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; }
    }
}

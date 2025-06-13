namespace InventoryManagement.Models
{
    public class StockMovement
    {
        public int MovementId { get; set; }
        public string ProductSKU { get; set; }
        public string MovementType { get; set; } // 'add', 'remove', 'adjust'
        public int QuantityChanged { get; set; }
        public DateTime MovementTime { get; set; }
        public string Notes { get; set; }
    }
}

namespace InventoryManagementSystem.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string ProductSKU { get; set; }
        public int Quantity { get; set; }
        public decimal PriceEach { get; set; }
    }
}

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? SupplierId { get; set; }
    }
}

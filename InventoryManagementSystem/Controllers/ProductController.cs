using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Controllers
{
    public class ProductController
    {
        private readonly ProductRepository productRepo;
        private readonly StockMovementController movementController;

        public ProductController()
        {
            productRepo = new ProductRepository();
            movementController = new StockMovementController();
        }

        public List<Product> GetAllProducts()
        {
            return productRepo.GetAllProducts();
        }

        public Product GetProductBySKU(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                MessageBox.Show("SKU cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return productRepo.GetProductBySKU(sku);
        }

        public bool AddProduct(Product p)
        {
            if (!ValidateProduct(p, isNew: true)) return false;

            if (productRepo.GetProductBySKU(p.SKU) != null)
            {
                MessageBox.Show("A product with this SKU already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool success = productRepo.AddProduct(p);

            if (success && p.Quantity > 0)
            {
                movementController.LogMovement(new StockMovement
                {
                    ProductSKU = p.SKU,
                    MovementType = "add",
                    QuantityChanged = p.Quantity,
                    Notes = "Initial stock on product creation"
                });
            }

            return success;
        }

        public bool UpdateProduct(Product p)
        {
            if (!ValidateProduct(p)) return false;

            Product existing = productRepo.GetProductBySKU(p.SKU);
            if (existing == null)
            {
                MessageBox.Show("Product not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool success = productRepo.UpdateProduct(p);

            // Log stock movement only if quantity changed
            if (success && p.Quantity != existing.Quantity)
            {
                int qtyDiff = p.Quantity - existing.Quantity;

                movementController.LogMovement(new StockMovement
                {
                    ProductSKU = p.SKU,
                    MovementType = "adjust",
                    QuantityChanged = qtyDiff,
                    Notes = "Manual quantity adjustment"
                });
            }

            return success;
        }

        public bool DeleteProduct(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                MessageBox.Show("SKU is required for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return productRepo.DeleteProduct(sku);
        }

        private bool ValidateProduct(Product p, bool isNew = false)
        {
            if (p == null)
            {
                MessageBox.Show("Product object is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (isNew && string.IsNullOrWhiteSpace(p.SKU))
            {
                MessageBox.Show("SKU is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(p.Name))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (p.Quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (p.Price < 0)
            {
                MessageBox.Show("Price cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

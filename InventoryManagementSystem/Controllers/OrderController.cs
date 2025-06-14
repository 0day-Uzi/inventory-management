using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Controllers
{
    public class OrderController
    {
        private readonly OrderRepository orderRepo;
        private readonly ProductRepository productRepo;
        private readonly StockMovementController movementController;

        public OrderController()
        {
            orderRepo = new OrderRepository();
            productRepo = new ProductRepository();
            movementController = new StockMovementController();
        }

        // ✅ Places a new order (status = "placed")
        public bool PlaceOrder(Order order, List<OrderItem> items)
        {
            if (!ValidateOrder(order, items)) return false;

            // Ensure total is accurate
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.PriceEach * item.Quantity;
            }
            order.TotalAmount = total;
            order.OrderStatus = "placed"; // Explicitly set

            bool success = orderRepo.AddOrder(order, items);

            if (success)
            {
                MessageBox.Show("✅ Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return success;
        }

        // ✅ Receives stock and logs movement
        public bool ReceiveOrder(List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("No items to receive.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (var item in items)
            {
                Product existing = productRepo.GetProductBySKU(item.ProductSKU);
                if (existing == null) continue;

                existing.Quantity += item.Quantity;

                bool updated = productRepo.UpdateProduct(existing);
                if (updated)
                {
                    movementController.LogMovement(new StockMovement
                    {
                        ProductSKU = item.ProductSKU,
                        MovementType = "add",
                        QuantityChanged = item.Quantity,
                        Notes = "Stock received from supplier"
                    });
                }
            }

            // ✅ Update the order status
            int orderId = items[0].OrderId;
            bool statusUpdated = orderRepo.MarkOrderAsReceived(orderId);

            if (statusUpdated)
            {
                MessageBox.Show("✅ Order received and stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }


        // ✅ Fetch all orders
        public List<Order> GetAllOrders()
        {
            return orderRepo.GetAllOrders();
        }

        // ✅ Fetch order items
        public List<OrderItem> GetItemsByOrderId(int orderId)
        {
            return orderRepo.GetItemsByOrderId(orderId);
        }

        // ✅ Validation
        private bool ValidateOrder(Order order, List<OrderItem> items)
        {
            if (order == null || items == null || items.Count == 0)
            {
                MessageBox.Show("Order and items must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (var item in items)
            {
                if (string.IsNullOrWhiteSpace(item.ProductSKU))
                {
                    MessageBox.Show("Product SKU is missing in one or more items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (item.Quantity <= 0)
                {
                    MessageBox.Show($"Invalid quantity for product {item.ProductSKU}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (item.PriceEach < 0)
                {
                    MessageBox.Show($"Invalid price for product {item.ProductSKU}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}

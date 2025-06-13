using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Controllers
{
    public class StockMovementController
    {
        private readonly StockMovementRepository movementRepo;

        public StockMovementController()
        {
            movementRepo = new StockMovementRepository();
        }

        public bool LogMovement(StockMovement m)
        {
            if (!ValidateMovement(m)) return false;

            return movementRepo.AddStockMovement(m);
        }

        public List<StockMovement> GetMovementsBySKU(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                MessageBox.Show("Product SKU is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<StockMovement>();
            }

            return movementRepo.GetMovementsBySKU(sku);
        }

        public List<StockMovement> GetAllMovements()
        {
            return movementRepo.GetAllMovements();
        }

        private bool ValidateMovement(StockMovement m)
        {
            if (m == null)
            {
                MessageBox.Show("Movement data is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.ProductSKU))
            {
                MessageBox.Show("Product SKU is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.MovementType) ||
                (m.MovementType != "add" && m.MovementType != "remove" && m.MovementType != "adjust"))
            {
                MessageBox.Show("Movement type must be 'add', 'remove', or 'adjust'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (m.QuantityChanged == 0)
            {
                MessageBox.Show("Quantity changed cannot be zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

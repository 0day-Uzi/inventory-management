using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repositories;

namespace InventoryManagementSystem.Controllers
{
    public class SupplierController
    {
        private readonly SupplierRepository supplierRepo;

        public SupplierController()
        {
            supplierRepo = new SupplierRepository();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return supplierRepo.GetAllSuppliers();
        }

        public Supplier GetSupplierById(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("Invalid supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return supplierRepo.GetSupplierById(id);
        }

        public bool AddSupplier(Supplier s)
        {
            if (!ValidateSupplier(s, isNew: true)) return false;

            return supplierRepo.AddSupplier(s);
        }

        public bool UpdateSupplier(Supplier s)
        {
            if (!ValidateSupplier(s)) return false;

            if (supplierRepo.GetSupplierById(s.SupplierId) == null)
            {
                MessageBox.Show("Supplier not found.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return supplierRepo.UpdateSupplier(s);
        }

        public bool DeleteSupplier(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("Supplier ID is required for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return supplierRepo.DeleteSupplier(id);
        }

        private bool ValidateSupplier(Supplier s, bool isNew = false)
        {
            if (s == null)
            {
                MessageBox.Show("Supplier object is null.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (isNew && s.SupplierId < 0)
            {
                MessageBox.Show("Supplier ID must be non-negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(s.SupplierName))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(s.Phone))
            {
                MessageBox.Show("Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(s.Email))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(s.Email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(s.Address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Basic regex pattern for email validation
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}

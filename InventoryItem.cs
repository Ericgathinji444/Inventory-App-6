using System;

namespace BusinessLayer
{
    public class InventoryItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string Supplier { get; set; }
        public DateTime DateAdded { get; set; }

        public InventoryItem(string description, int quantity, decimal cost, string supplier, DateTime dateAdded)
        {
            Description = description;
            Quantity = quantity;
            Cost = cost;
            Supplier = supplier;
            DateAdded = dateAdded;
        }
    }
}

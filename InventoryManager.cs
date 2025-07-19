// Name: Eric Gathinji
// Project: PresentationLayer
// Citation: Adapted for CST-150 Inventory Management Application 
// from Grand Canyon University Activity & Milestone guidelines.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BusinessLayer
{
    public class InventoryManager
    {
        // Public property to access the list of inventory items
        public List<InventoryItem> Items { get; private set; }

        // Private readonly field to store the path to the text file
        private readonly string filePath;

        /// <summary>
        /// Constructor initializes the file path and loads the inventory from file.
        /// </summary>
        public InventoryManager(string path)
        {
            filePath = path;
            LoadInventory(); // Load data from file on creation
        }

        /// <summary>
        /// Loads the inventory items from a text file into the List<T>.
        /// </summary>
        public void LoadInventory()
        {
            Items = new List<InventoryItem>();

            // Exit early if the file doesn't exist
            if (!File.Exists(filePath))
                return;

            // Read each line and split it into attributes
            foreach (var line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(',');

                // Expecting exactly 5 values per line
                if (parts.Length == 5)
                {
                    Items.Add(new InventoryItem(
                        parts[0],                      // Description
                        int.Parse(parts[1]),           // Quantity
                        decimal.Parse(parts[2]),       // Cost
                        parts[3],                      // Supplier
                        DateTime.Parse(parts[4])       // DateAdded
                    ));
                }
            }
        }

        /// <summary>
        /// Saves the current inventory list back to the text file.
        /// </summary>
        public void SaveInventory()
        {
            // Create a collection of formatted strings from the list
            var lines = Items.Select(i =>
                $"{i.Description},{i.Quantity},{i.Cost},{i.Supplier},{i.DateAdded:yyyy-MM-dd}");

            // Write the lines to the file
            File.WriteAllLines(filePath, lines);
        }

        /// <summary>
        /// Adds a new item to the inventory list and saves it.
        /// </summary>
        public void AddItem(InventoryItem item)
        {
            Items.Add(item);
            SaveInventory(); // Persist changes
        }

        /// <summary>
        /// Removes an item from the inventory list and saves the changes.
        /// </summary>
        public void RemoveItem(InventoryItem item)
        {
            Items.Remove(item);
            SaveInventory(); // Persist changes
        }

        /// <summary>
        /// Increments the quantity of a specified inventory item by 1.
        /// </summary>
        public void IncrementQuantity(InventoryItem item)
        {
            item.Quantity++;
            SaveInventory(); // Persist updated quantity
        }

        /// <summary>
        /// Decrements the quantity of a specified inventory item if it's greater than 0.
        /// </summary>
        public void DecrementQuantity(InventoryItem item)
        {
            if (item.Quantity > 0)
            {
                item.Quantity--;
                SaveInventory(); // Persist updated quantity
            }
        }
    }
}

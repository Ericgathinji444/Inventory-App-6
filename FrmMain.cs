// Name: Eric Gathinji
// Project: PresentationLayer
// File: FrmMain.cs
// Framework: .NET 8
// Citation: Adapted for CST-150 Inventory Management Application 
// from Grand Canyon University Activity & Milestone guidelines.


using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        // Declare an instance of the InventoryManager from the BusinessLayer
        private InventoryManager manager;

        public FrmMain()
        {
            InitializeComponent();

            // Define the full path to the inventory text file
            string filePath = Path.Combine(Application.StartupPath, "Data", "Inventory.txt");

            // Initialize InventoryManager with the file path and load inventory items
            manager = new InventoryManager(filePath);

            // Populate the DataGridView with the current inventory
            LoadGrid();
        }

        /// <summary>
        /// Loads the inventory items into the DataGridView from the inventory list.
        /// </summary>
        private void LoadGrid()
        {
            dgvInventory.Rows.Clear(); // Clear existing rows

            // Loop through all inventory items and add them to the grid
            foreach (var item in manager.Items)
            {
                dgvInventory.Rows.Add(
                    item.Description,
                    item.Quantity.ToString("N0"), // Format quantity with commas
                    item.Cost.ToString("C2"),     // Format cost with $ and 2 decimal places
                    item.Supplier,
                    item.DateAdded.ToShortDateString()
                );
            }
        }

        /// <summary>
        /// Adds a new inventory item based on user input and refreshes the grid.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new InventoryItem from the text boxes
                var newItem = new InventoryItem(
                    txtDescription.Text,
                    int.Parse(txtQuantity.Text),
                    decimal.Parse(txtCost.Text),
                    txtSupplier.Text,
                    DateTime.Now
                );

                // Add the new item to the inventory list and update file
                manager.AddItem(newItem);

                // Reload the updated list into the grid
                LoadGrid();
            }
            catch
            {
                // Show error message for invalid input
                MessageBox.Show("Invalid input. Please enter all fields correctly.");
            }
        }

        /// <summary>
        /// Deletes the selected inventory item from the list and updates the grid.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                // Get the description of the selected item
                string desc = dgvInventory.SelectedRows[0].Cells[0].Value.ToString();

                // Find the item in the inventory list
                var item = manager.Items.FirstOrDefault(i => i.Description == desc);

                // Remove it if found
                if (item != null)
                {
                    manager.RemoveItem(item);
                    LoadGrid();
                }
            }
        }

        /// <summary>
        /// Increments the quantity of the selected inventory item.
        /// </summary>
        private void btnInc_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                // Get selected item description
                string desc = dgvInventory.SelectedRows[0].Cells[0].Value.ToString();

                // Locate the item in the inventory list
                var item = manager.Items.FirstOrDefault(i => i.Description == desc);

                if (item != null)
                {
                    manager.IncrementQuantity(item);
                    LoadGrid();
                }
            }
        }

        /// <summary>
        /// Decrements the quantity of the selected inventory item.
        /// </summary>
        private void btnDec_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                string desc = dgvInventory.SelectedRows[0].Cells[0].Value.ToString();
                var item = manager.Items.FirstOrDefault(i => i.Description == desc);

                if (item != null)
                {
                    manager.DecrementQuantity(item);
                    LoadGrid();
                }
            }
        }
    }
}

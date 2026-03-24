using System;
using System.Windows.Forms;

namespace Demo6_InventoryTracker
{
    public partial class Form1 : Form
    {
        // Warehouse object using Dictionary<string, Item>
        private Warehouse _warehouse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create warehouse with initial inventory
            _warehouse = new Warehouse("Main Warehouse");

            _warehouse.AddItem(new Item("ITM-100", "Laptop", "Electronics", 899.99, 25));
            _warehouse.AddItem(new Item("ITM-101", "Office Chair", "Furniture", 249.99, 40));
            _warehouse.AddItem(new Item("ITM-102", "Whiteboard", "Office Supplies", 79.99, 60));
            _warehouse.AddItem(new Item("ITM-103", "Projector", "Electronics", 549.99, 15));
            _warehouse.AddItem(new Item("ITM-104", "Desk Organizer", "Office Supplies", 19.99, 100));

            // Display the inventory
            RefreshInventoryDisplay();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string id = txtItemId.Text.Trim();
            string name = txtItemName.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in Item ID, Name, and Category.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price;
            if (!double.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stock;
            if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock count.", "Invalid Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item newItem = new Item(id, name, category, price, stock);
            bool added = _warehouse.AddItem(newItem);

            if (added)
            {
                // Clear inputs
                txtItemId.Text = "";
                txtItemName.Text = "";
                txtCategory.Text = "";
                txtPrice.Text = "";
                txtStock.Text = "";
                RefreshInventoryDisplay();
            }
            else
            {
                MessageBox.Show($"An item with ID \"{id}\" already exists.", "Duplicate ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string id = txtRemoveId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an Item ID to remove.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool removed = _warehouse.RemoveItem(id);

            if (removed)
            {
                txtRemoveId.Text = "";
                RefreshInventoryDisplay();
            }
            else
            {
                MessageBox.Show($"Item with ID \"{id}\" was not found.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearchId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an Item ID to search.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item found = _warehouse.SearchById(id);

            if (found != null)
            {
                lblSearchResult.Text = found.ToString();
            }
            else
            {
                lblSearchResult.Text = $"No item found with ID: {id}";
            }
        }

        // Refresh the RichTextBox with the current inventory
        private void RefreshInventoryDisplay()
        {
            rtbInventory.Text = _warehouse.ToString();
        }
    }
}

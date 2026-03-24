using System;
using System.Windows.Forms;

namespace Demo4_ProductSearch
{
    public partial class Form1 : Form
    {
        // Array of Product objects
        private Product[] _products;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create product data
            _products = new Product[]
            {
                new Product("SKU-1001", "Wireless Mouse", "Logitech", 29.99, 150),
                new Product("SKU-1002", "Mechanical Keyboard", "Corsair", 89.99, 75),
                new Product("SKU-1003", "USB-C Hub", "Anker", 34.99, 200),
                new Product("SKU-1004", "Monitor Stand", "AmazonBasics", 24.99, 120),
                new Product("SKU-1005", "Webcam HD", "Logitech", 59.99, 90),
                new Product("SKU-1006", "Desk Lamp", "BenQ", 109.99, 45),
                new Product("SKU-1007", "Mouse Pad XL", "SteelSeries", 19.99, 300),
                new Product("SKU-1008", "Headset", "HyperX", 49.99, 110)
            };

            // Wire up KeyDown events so Enter triggers search
            txtSearchSku.KeyDown += TxtSearchSku_KeyDown;
            txtSearchName.KeyDown += TxtSearchName_KeyDown;
        }

        // KEYBOARD EVENT: Enter key in SKU TextBox triggers SKU search
        private void TxtSearchSku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSku.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // KEYBOARD EVENT: Enter key in Name TextBox triggers Name search
        private void TxtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchName.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Search by SKU (exact match, case-insensitive)
        private void btnSearchSku_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchSku.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a SKU to search.", "Empty Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search through products array
            foreach (Product product in _products)
            {
                if (product.SKU.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayProduct(product);
                    return;
                }
            }

            // Not found
            ClearResults();
            MessageBox.Show($"No product found with SKU: {searchTerm}", "Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Search by Name (partial match, case-insensitive)
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchName.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a product name to search.", "Empty Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search through products array for partial match
            foreach (Product product in _products)
            {
                if (product.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    DisplayProduct(product);
                    return;
                }
            }

            // Not found
            ClearResults();
            MessageBox.Show($"No product found matching: {searchTerm}", "Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Display product details in the results group
        private void DisplayProduct(Product product)
        {
            lblSkuValue.Text = product.SKU;
            lblNameValue.Text = product.Name;
            lblBrandValue.Text = product.Brand;
            lblPriceValue.Text = $"${product.Price:F2}";
            lblQuantityValue.Text = product.Quantity.ToString();
        }

        // Clear all result labels
        private void ClearResults()
        {
            lblSkuValue.Text = "";
            lblNameValue.Text = "";
            lblBrandValue.Text = "";
            lblPriceValue.Text = "";
            lblQuantityValue.Text = "";
        }
    }
}

namespace CH08_Demo4
{
    public partial class ProductCatalogSearchForm : Form
    {
        // Declare parallel arrays at class level for product data
        string[] productNames = {
            "Wireless Mouse",
            "Mechanical Keyboard",
            "USB-C Hub",
            "Monitor Stand",
            "Webcam HD",
            "Desk Lamp LED"
        };

        string[] categories = {
            "Computer Accessories",
            "Computer Accessories",
            "Computer Accessories",
            "Office Furniture",
            "Video Equipment",
            "Lighting"
        };

        double[] prices = {
            29.99,
            89.99,
            45.00,
            34.99,
            59.99,
            24.99
        };
        public ProductCatalogSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term and convert to lowercase
            string searchTerm = txtSearch.Text.ToLower();

            // Variable to track if we found a match
            bool found = false;

            // Linear search through parallel arrays
            for (int i = 0; i < productNames.Length; i++)
            {
                // Check if product name contains the search term
                if (productNames[i].ToLower().Contains(searchTerm))
                {
                    // Found a match - display the information
                    lblProductName.Text = productNames[i];
                    lblCategory.Text = categories[i];
                    lblPrice.Text = prices[i].ToString("C");
                    found = true;
                    break;
                }

                // Check if category contains the search term
                if (categories[i].ToLower().Contains(searchTerm))
                {
                    // Found a match - display the information
                    lblProductName.Text = productNames[i];
                    lblCategory.Text = categories[i];
                    lblPrice.Text = prices[i].ToString("C");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lblProductName.Text = "Product Not Found";
                lblCategory.Text = "Product Not Found";
                lblPrice.Text = "Product Not Found";
            }
        }
    }
}

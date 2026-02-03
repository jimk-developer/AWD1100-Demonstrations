namespace CH06_Part1_Demo6
{
    public partial class CustomPizzaOrderForm : Form
    {
        public CustomPizzaOrderForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the size and number of toppings using methods
            string input = txtSize.Text.ToLower();

            string size = GetSize(input);
            int toppings = GetToppings();

            // Calculate the total cost using the method
            decimal totalCost = CalculateTotalCost(size, toppings);

            // Display the results
            lblSize.Text = size;
            lblToppings.Text = toppings.ToString();
            lblTotal.Text = totalCost.ToString("C");

        }
        // Method that gets the pizza size from the text box
        // Returns "small", "medium", "large", or "other"
        // User enters: s, m, or l
        private static string GetSize(string input)
        {

            return input switch
            {
                "s" => "small",
                "m" => "medium",
                "l" => "large",
                _ => "unknown" // This checks for "impossible" cases
            };
        }

        // Method that gets the number of toppings from the text box
        // Returns the number as an int
        private int GetToppings()
        {
            int numToppings = int.Parse(txtToppings.Text);
            return numToppings;
        }

        // Method that calculates the base cost based on pizza size
        // Small = $8, Medium = $10, Large = $12, Other = $14
        private static decimal CalculateSizeCost(string size) => size switch
        {
            "small" => 8.00m,
            "medium" => 10.00m,
            "large" => 12.00m,
            _ => 14.00m // The underscore handles the 'else' case
        };

        // Method that calculates the cost of toppings
        // Each topping is $1.50
        private decimal CalculateToppingCost(int numToppings)
        {
            decimal costPerTopping = 1.50m;
            return numToppings * costPerTopping;
        }

        // Method that calculates the total cost of the pizza
        // Calls CalculateSizeCost and CalculateToppingCost
        private decimal CalculateTotalCost(string size, int numToppings)
        {
            decimal sizeCost = CalculateSizeCost(size);
            decimal toppingCost = CalculateToppingCost(numToppings);
            decimal total = sizeCost + toppingCost;
            return total;
        }
    }
}

namespace CH06_Part2_Demo4
{
    public partial class PriceChecker : Form
    {
        public PriceChecker()
        {
            InitializeComponent();
        }

        private void AnalyzePrices(out double cheapest, out double mostExpensive,
        out double average, params double[] prices)
        {
            cheapest = prices[0];
            mostExpensive = prices[0];
            double total = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < cheapest)
                    cheapest = prices[i];

                if (prices[i] > mostExpensive)
                    mostExpensive = prices[i];

                total += prices[i];
            }

            average = total / prices.Length;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Store text boxes and error labels in arrays for easy looping
            TextBox[] priceBoxes = { txtPrice1, txtPrice2, txtPrice3,
            txtPrice4, txtPrice5 };

            Label[] errorLabels = { lblError1, lblError2, lblError3,
            lblError4, lblError5 };

            // Clear previous errors and results
            for (int i = 0; i < errorLabels.Length; i++)
                errorLabels[i].Text = "";

            lblCheapest.Text = "";
            lblMostExpensive.Text = "";
            lblAverage.Text = "";

            // Collect valid prices into a list
            List<double> priceList = new List<double>();
            bool hasError = false;

            for (int i = 0; i < priceBoxes.Length; i++)
            {
                string input = priceBoxes[i].Text.Trim();

                // Skip empty text boxes
                if (input == "")
                    continue;

                // Validate: must be a valid number
                if (!double.TryParse(input, out double price))
                {
                    errorLabels[i].Text = "Invalid price";
                    hasError = true;
                }
                // Validate: price must be positive
                else if (price <= 0)
                {
                    errorLabels[i].Text = "Must be greater than 0";
                    hasError = true;
                }
                else
                {
                    priceList.Add(price);
                }
            }

            // Stop if there were any validation errors
            if (hasError)
                return;

            // Must have at least one price
            if (priceList.Count == 0)
            {
                lblCheapest.Text = "Error: Enter at least one price";
                return;
            }

            // Call the method with out parameters
            // .ToArray() converts the List to an array for the params parameter
            AnalyzePrices(out double cheapest, out double mostExpensive,
                out double average, priceList.ToArray());

            // Display the results
            lblCheapest.Text = $"Cheapest: {cheapest:C}";
            lblMostExpensive.Text = $"Most Expensive: {mostExpensive:C}";
            lblAverage.Text = $"Average: {average:C}";
        }
    }
}

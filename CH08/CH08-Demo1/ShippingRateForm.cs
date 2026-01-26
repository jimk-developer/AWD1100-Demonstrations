namespace CH08_Demo1
{
    public partial class ShippingRateForm : Form
    {
        // Declare parallel arrays at class level (outside any method)
        // These store the weight limits and corresponding shipping rates
        int[] weightLimits = { 1, 3, 5, 10, 20, 30, 50, 75 };
        double[] shippingRates = { 5.99, 8.99, 12.99, 15.99, 22.99, 29.99, 39.99, 54.99 };
        public ShippingRateForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous error message
            lblError.Text = "";

            // Parse the weight from the text box


            if (int.TryParse(txtWeight.Text, out int weight))
            {

                // Variable to track if we found a matching rate
                bool found = false;

                // Linear search through the weight limits array
                for (int i = 0; i < weightLimits.Length; i++)
                {
                    // Check if the weight is within this tier
                    if (weight <= weightLimits[i])
                    {
                        // Found the rate - display it
                        lblRate.Text = shippingRates[i].ToString("C");
                        found = true;
                        break;  // Exit the loop, we found our answer
                    }
                }

                // If we didn't find a rate, weight exceeds maximum
                if (!found)
                {
                    lblError.Text = "Weight exceeds 75 lbs.";
                    lblError.ForeColor = Color.Red;
                    lblRate.Text = "";
                }
            }
            else
            {
                lblError.Text = "Invalid Data, Please try again";
                lblError.ForeColor = Color.Red;
                lblRate.Text = "";
            }
        }
    }
}

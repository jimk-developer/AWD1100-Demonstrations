namespace CH06_Part1_Demo4
{
    public partial class FlooringCostEstimatorForm : Form
    {
        public FlooringCostEstimatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            // 2. Validate the input
            // TryParse returns 'true' if it works, and puts the number in the 'out' variable.
            bool isLengthValid = int.TryParse(txtLength.Text, out int length);
            bool isWidthValid = int.TryParse(txtWidth.Text, out int width);

            // 3. Check if both are valid AND positive numbers
            if (isLengthValid && isWidthValid && length > 0 && width > 0)
            {

                // Call the method to calculate total area
                int totalArea = CalculateTotalArea(length, width);

                // Call the method to calculate flooring estimate
                // (Note: This might need to be called on the class name if you made it static earlier)
                decimal totalCost = CalculateFlooringEstimate(totalArea);

                // Display the results
                lblArea.Text = totalArea + " sq ft";
                lblCost.Text = totalCost.ToString("C");

            }
            else
            {
                // Show an error message using a MessageBox)
                MessageBox.Show("Please enter valid positive whole numbers for both length and width.");
            }
        }
        // Method that calculates the total floor area
        // Accepts length and width in feet, returns area in square feet
        private int CalculateTotalArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
        // Method that calculates the flooring cost estimate
        // Accepts total area in square feet, returns total cost in dollars
        // Price is $8 per square foot
        private decimal CalculateFlooringEstimate(int totalArea)
        {
            double pricePerSqFt = 8.00;
            decimal totalCost = (decimal)(totalArea * pricePerSqFt);
            return totalCost;
        }
    }
}

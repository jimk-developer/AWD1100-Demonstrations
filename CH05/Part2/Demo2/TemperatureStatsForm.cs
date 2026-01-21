namespace Demo2
{
    public partial class TemperatureStatsForm : Form
    {
        // Class-level variables to maintain state across button clicks
        private int count = 0;
        private double sum = 0;
        private double min = double.MaxValue;
        private double max = double.MinValue;

        // Valid temperature range (in Fahrenheit)
        private const double MIN_VALID_TEMP = -50;
        private const double MAX_VALID_TEMP = 150;

        public TemperatureStatsForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Clear any previous error message
            if (lblError != null)
            {
                lblError.Text = "";
            }
            // Try to parse the input
            double temperature;
            if (!double.TryParse(txtTemperature.Text, out temperature))
            {
                if (lblError != null)
                {
                    lblError.Text = "Please enter a valid number";
                }
                return;
            }

            // Validate the temperature is within acceptable range
            if (temperature < MIN_VALID_TEMP || temperature > MAX_VALID_TEMP)
            {
                if (lblError != null)
                {
                    lblError.Text = "Invalid temperature (must be between -50 and 150)";
                }
                return;
            }

            // Accept the temperature - update statistics
            count++;
            sum += temperature;

            // Update min if this temperature is lower
            if (temperature < min)
            {
                min = temperature;
            }

            // Update max if this temperature is higher
            if (temperature > max)
            {
                max = temperature;
            }

            // Update all display labels
            lblCount.Text = "Number of readings: " + count;
            lblSum.Text = "Sum of temperatures: " + sum.ToString("F1");
            lblAverage.Text = "Average temperature: " + (sum / count).ToString("F1");
            lblMin.Text = "Lowest temperature: " + min.ToString("F1");
            lblMax.Text = "Highest temperature: " + max.ToString("F1");

            // Clear the input for the next entry
            txtTemperature.Clear();
            txtTemperature.Focus();

        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            sum = 0;
            min = double.MaxValue;
            max = double.MinValue;

            lblCount.Text = "";
            lblSum.Text = "";
            lblAverage.Text = "";
            lblMin.Text = "";
            lblMax.Text = "";

            if (lblError != null)
            {
                lblError.Text = "";
            }
        }
    }
}

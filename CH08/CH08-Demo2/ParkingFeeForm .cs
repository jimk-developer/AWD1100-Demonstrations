using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CH08_Demo2
{
    public partial class Form1 : Form
    {
        // Declare parallel arrays at class level
        // hourThresholds: maximum hours for each tier
        // hourlyRates: rate per hour for each tier

        int[] hourThresholds = { 1, 3, 6, 24 };
        double[] hourlyRates = { 5.00, 4.00, 3.00, 2.50 };

        // Rate tiers:
        // 1 hour or less: $5.00/hour
        // 2-3 hours: $4.00/hour
        // 4-6 hours: $3.00/hour
        // 7+ hours: $2.50/hour
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            // Parse the hours from the text box
            if (int.TryParse(txtHours.Text, out int hours))
            {
                // Variable to store the hourly rate we find
                double hourlyRate = 0;

                // Linear search to find the appropriate rate tier
                for (int i = 0; i < hourThresholds.Length; i++)
                {
                    if (hours <= hourThresholds[i])
                    {
                        hourlyRate = hourlyRates[i];
                        break;
                    }
                }                

                // Calculate the total fee
                double totalFee = hours * hourlyRate;

                // Display the results
                lblHourlyRate.Text = hourlyRate.ToString("C");
                lblTotalFee.Text = totalFee.ToString("C");
            }
            else
            {
                lblError.Text = "Please enter a valid number of hours";
                lblError.ForeColor = Color.Red;
            }
        }    
    }
}

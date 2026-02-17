using System;
using System.Windows.Forms;

namespace Demo5_ShippingCalculator
{
    public partial class Form1 : Form
    {
        // Current shipment object (may be null)
        private Shipment currentShipment = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Calculate button click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate description
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                lblResult.Text = "Please enter a description";
                return;
            }

            // Validate weight
            double weight;
            if (!double.TryParse(txtWeight.Text, out weight))
            {
                lblResult.Text = "Please enter a valid weight";
                return;
            }
            if (weight <= 0)
            {
                lblResult.Text = "Weight must be greater than 0";
                return;
            }

            // Validate rate
            decimal rate;
            if (!decimal.TryParse(txtRate.Text, out rate))
            {
                lblResult.Text = "Please enter a valid rate";
                return;
            }
            if (rate <= 0)
            {
                lblResult.Text = "Rate must be greater than 0";
                return;
            }

            // Create or update shipment
            if (currentShipment == null)
            {
                // Create new shipment
                currentShipment = new Shipment(
                    txtDescription.Text.Trim(),
                    weight,
                    rate
                );
                DisplayShipment("New shipment created!");
            }
            else
            {
                // Update existing shipment
                currentShipment.Description = txtDescription.Text.Trim();
                currentShipment.Weight = weight;
                currentShipment.RatePerPound = rate;
                DisplayShipment("Shipment updated!");
            }
        }

        // Display shipment details
        private void DisplayShipment(string message)
        {
            decimal baseCost = (decimal)currentShipment.Weight * currentShipment.RatePerPound;
            
            lblResult.Text = $"{message}\n\n" +
                            $"Description: {currentShipment.Description}\n" +
                            $"Weight: {currentShipment.Weight:F1} lbs\n" +
                            $"Rate: {currentShipment.RatePerPound:C}/lb\n\n" +
                            $"--- Cost Breakdown ---\n" +
                            $"Base Cost: {baseCost:C}\n" +
                            $"   ({currentShipment.Weight:F1} × {currentShipment.RatePerPound:C})\n" +
                            $"Handling Fee: $4.50\n\n" +
                            $"TOTAL: {currentShipment.TotalCost:C}";
        }

        // Clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentShipment = null;
            txtDescription.Clear();
            txtWeight.Clear();
            txtRate.Clear();
            lblResult.Text = "Enter shipment details and click Calculate.";
            txtDescription.Focus();
        }
    }
}

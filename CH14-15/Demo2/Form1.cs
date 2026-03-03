using System;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VehicleType_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable groups based on selection
            grpFuelType.Enabled = radElectric.Checked;
            grpTrimLevel.Enabled = radLuxury.Checked;
            grpDriveType.Enabled = radLuxury.Checked;
        }

        private FuelType GetSelectedFuelType()
        {
            if (radDiesel.Checked) return FuelType.DIESEL;
            if (radElectricFuel.Checked) return FuelType.ELECTRIC;
            if (radHybrid.Checked) return FuelType.HYBRID;
            return FuelType.GASOLINE;
        }

        private TrimLevel GetSelectedTrimLevel()
        {
            if (radSport.Checked) return TrimLevel.SPORT;
            if (radPremium.Checked) return TrimLevel.PREMIUM;
            if (radLuxuryTrim.Checked) return TrimLevel.LUXURY;
            return TrimLevel.BASE;
        }

        private DriveType GetSelectedDriveType()
        {
            if (radRWD.Checked) return DriveType.RWD;
            if (radAWD.Checked) return DriveType.AWD;
            return DriveType.FWD;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Please enter Make, Model, and Year.");
                return;
            }

            int year;
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("Year must be a number.");
                return;
            }

            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();

            // Create appropriate object based on radio button selection
            Vehicle vehicle;

            if (radElectric.Checked)
            {
                vehicle = new ElectricVehicle(make, model, year, GetSelectedFuelType());
            }
            else if (radLuxury.Checked)
            {
                vehicle = new LuxuryVehicle(make, model, year, GetSelectedTrimLevel(), GetSelectedDriveType());
            }
            else
            {
                vehicle = new Vehicle(make, model, year);
            }

            // Display results
            lblCost.Text = $"Cost: {vehicle.DailyRate:C}";
            lblDetails.Text = vehicle.ToString();
        }
    }
}

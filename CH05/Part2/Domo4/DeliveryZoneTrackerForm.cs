using System.Security.Policy;

namespace Domo4
{
    public partial class DeliveryZoneTrackerForm : Form
    {
        // Class-level variables to track miles for each zone
        private double northMiles = 0;
        private double southMiles = 0;
        private double westMiles = 0;
        public DeliveryZoneTrackerForm()
        {
            InitializeComponent();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            ProcessDelivery("South");

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            ProcessDelivery("North");

        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            ProcessDelivery("West");
        }

        public void ProcessDelivery(string zone)
        {
            double miles;
            if (!double.TryParse(txtMiles.Text, out miles))
            {
                return;  // Invalid input - do nothing
            }

            // Add miles to appropriate zone
            if (zone == "North")
            {
                northMiles += miles;
            }
            else if (zone == "South")
            {
                southMiles += miles;
            }
            else if (zone == "West")
            {
                westMiles += miles;
            }

            // Update all zone labels
            lblNorth.Text = "North Zone Miles: " + northMiles.ToString("F1");
            lblSouth.Text = "South Zone Miles: " + southMiles.ToString("F1");
            lblWest.Text = "West Zone Miles: " + westMiles.ToString("F1");

            // Calculate and display total miles
            double totalMiles = northMiles + southMiles + westMiles;
            lblTotal.Text = "Total Miles: " + totalMiles.ToString("F1");

            // Determine and display zone with most miles
            if (northMiles >= southMiles && northMiles >= westMiles)
            {
                lblHighest.Text = "North zone has the most miles";
            }
            else if (southMiles >= northMiles && southMiles >= westMiles)
            {
                lblHighest.Text = "South zone has the most miles";
            }
            else
            {
                lblHighest.Text = "West zone has the most miles";
            }

            // Clear input for next entry
            txtMiles.Clear();
            txtMiles.Focus();
        }
    }
}

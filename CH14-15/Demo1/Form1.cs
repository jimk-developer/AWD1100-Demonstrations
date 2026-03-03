using System;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        // Array to store packages (up to 15)
        private Package[] packages = new Package[15];
        private int packageCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtRecipient.Text) ||
                string.IsNullOrWhiteSpace(txtShipDate.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Please enter Recipient, Ship Date, and Weight.");
                return;
            }

            // Check capacity
            if (packageCount >= packages.Length)
            {
                MessageBox.Show("Maximum of 15 packages reached.");
                return;
            }

            // Parse inputs
            DateTime shipDate;
            if (!DateTime.TryParse(txtShipDate.Text, out shipDate))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }

            double weight;
            if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Weight must be a positive number.");
                return;
            }

            string recipient = txtRecipient.Text.Trim();

            // Decide which type of object to create based on Policy Number
            Package pkg;

            if (!string.IsNullOrWhiteSpace(txtPolicyNumber.Text))
            {
                // Has a policy number -> InsuredPackage
                pkg = new InsuredPackage(recipient, shipDate, weight, txtPolicyNumber.Text.Trim());
            }
            else
            {
                // No policy number -> regular Package
                pkg = new Package(recipient, shipDate, weight);
            }

            // Add to array
            packages[packageCount] = pkg;
            packageCount++;

            // Update transaction log (newest at top)
            UpdateLog();

            // Clear fields
            txtRecipient.Clear();
            txtShipDate.Clear();
            txtWeight.Clear();
            txtPolicyNumber.Clear();
            txtRecipient.Focus();
        }

        private void UpdateLog()
        {
            string log = "";
            // Display newest first
            for (int i = packageCount - 1; i >= 0; i--)
            {
                log += packages[i].ToString() + "\n";
            }
            lblTransactionLog.Text = log;
        }
    }
}

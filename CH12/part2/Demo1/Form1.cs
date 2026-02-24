using System;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        // Available pastries with prices
        private string[] pastryNames = { "Croissant", "Muffin", "Bagel", "Danish", "Scone" };
        private decimal[] pastryPrices = { 3.50m, 2.75m, 2.25m, 3.25m, 2.95m };

        public Form1()
        {
            InitializeComponent();
            LoadOptions();
        }

        // Load dropdown options
        private void LoadOptions()
        {
            // Load drink types from enum
            cmbDrinkType.DataSource = Enum.GetValues(typeof(DrinkType));
            
            // Load drink sizes from enum
            cmbDrinkSize.DataSource = Enum.GetValues(typeof(DrinkSize));

            // Load pastries
            cmbPastry.Items.Add("-- No Pastry --");
            for (int i = 0; i < pastryNames.Length; i++)
            {
                cmbPastry.Items.Add($"{pastryNames[i]} - {pastryPrices[i]:C}");
            }
            cmbPastry.SelectedIndex = 0;
        }

        // Place Order button click
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Validate customer name
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                lblResult.Text = "Please enter customer name";
                return;
            }

            // Get selected drink type and size from enums
            DrinkType selectedType = (DrinkType)cmbDrinkType.SelectedItem;
            DrinkSize selectedSize = (DrinkSize)cmbDrinkSize.SelectedItem;

            // Create Drink object (COMPOSITION - will be part of CoffeeOrder)
            Drink drink = new Drink(selectedType, selectedSize);

            // Check if pastry is selected
            CoffeeOrder order;
            
            if (cmbPastry.SelectedIndex > 0)
            {
                // Create Pastry object (COMPOSITION - will be part of CoffeeOrder)
                int pastryIndex = cmbPastry.SelectedIndex - 1;
                Pastry pastry = new Pastry(
                    pastryNames[pastryIndex], 
                    pastryPrices[pastryIndex],
                    chkWarmed.Checked
                );

                // Create order WITH pastry (composition)
                order = new CoffeeOrder(txtCustomerName.Text.Trim(), drink, pastry);
            }
            else
            {
                // Create order WITHOUT pastry
                order = new CoffeeOrder(txtCustomerName.Text.Trim(), drink);
            }

            // Display the order
            lblResult.Text = order.Display();
        }

        // Clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            cmbDrinkType.SelectedIndex = 0;
            cmbDrinkSize.SelectedIndex = 0;
            cmbPastry.SelectedIndex = 0;
            chkWarmed.Checked = false;
            lblResult.Text = "Select items and place your order.";
            txtCustomerName.Focus();
        }
    }
}

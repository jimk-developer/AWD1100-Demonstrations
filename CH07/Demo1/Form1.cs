using Demo1;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo1_TipCalculator
{
    public partial class TipCalculatorForm : Form
    {
        public TipCalculatorForm()
        {
            InitializeComponent();
            // Pre-load tip percentages
            cmbTipPercent.Items.AddRange(new object[] { 10, 15, 18, 20, 25 });
            cmbTipPercent.SelectedIndex = 1; // Default to 15%
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblTipAmount.Text = "";
            lblTotal.Text = "";

            try
            {
                // This will throw FormatException if not a valid number
                decimal mealTotal = Convert.ToDecimal(txtMealTotal.Text);

                // Range validation
                if (mealTotal < 1.00m || mealTotal > 500.00m)
                {
                    throw new InvalidTotalMealException("Invalid Meal");
                    
                }

                // Calculate tip
                int tipPercent = (int)cmbTipPercent.SelectedItem;
                decimal tipAmount = mealTotal * tipPercent / 100m;
                decimal total = mealTotal + tipAmount;

                // Display results
                lblTipAmount.Text = "Tip: " + tipAmount.ToString("c");
                lblTotal.Text = "Total: " + total.ToString("c");
            }
            catch (InvalidTotalMealException)
            {
                lblError.Text = "AMOUNT OUT OF RANGE";
                lblError.ForeColor = Color.Red;
                txtMealTotal.Focus();
                return;
            }
            catch (FormatException)
            {
                lblError.Text = "INVALID AMOUNT";
                lblError.ForeColor = Color.Red;
                txtMealTotal.Focus();
            }
            catch (Exception)
            {
                lblError.Text = "Unkown error occured";

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMealTotal.Text = "";
            cmbTipPercent.SelectedIndex = 1;
            lblTipAmount.Text = "";
            lblTotal.Text = "";
            lblError.Text = "";
            txtMealTotal.Focus();
        }
    }
}

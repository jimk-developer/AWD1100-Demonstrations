using Demo4;
using System;
using System.Windows.Forms;

namespace Demo4_TemperatureConverter
{
    public partial class TemperatureConverterForm : Form
    {
        public TemperatureConverterForm()
        {
            InitializeComponent();
            rdoFtoC.Checked = true;
        }

        // ---- Generic Validation Methods ----

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            if (!decimal.TryParse(textBox.Text, out _))
            {
                MessageBox.Show(name + " must be a valid decimal.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsValidData()
        {
            return
                IsPresent(txtTemperature, "Temperature") &&
                IsDecimal(txtTemperature, "Temperature");
        }

        // ---- Conversion Methods (throw exceptions) ----

        public static decimal FahrenheitToCelsius(decimal fahrenheit)
        {
            if (fahrenheit < -459.67m)
                throw new InvalidFahrenheitException("Temperature cannot be below absolute zero (-459.67°F).");
            return (fahrenheit - 32m) * 5m / 9m;
        }

        public static decimal CelsiusToFahrenheit(decimal celsius)
        {
            if (celsius < -273.15m)
                throw new InvalidCelsiusException("Temperature cannot be below absolute zero (-273.15°C).");
            return celsius * 9m / 5m + 32m;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Layer 1: Validation
            if (IsValidData())
            {
                try
                {
                    // Layer 2: Try-Catch safety net
                    decimal temp = Convert.ToDecimal(txtTemperature.Text);

                    if (rdoFtoC.Checked)
                    {
                        decimal celsius = FahrenheitToCelsius(temp);
                        lblResult.Text = $"{temp:f2}°F = {celsius:f2}°C";
                    }
                    else
                    {
                        decimal fahrenheit = CelsiusToFahrenheit(temp);
                        lblResult.Text = $"{temp:f2}°C = {fahrenheit:f2}°F";
                    }
                }
                //catch (InvalidFahrenheitException ex)
                //{
                //    MessageBox.Show(ex.Message, "Conversion Error",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                catch (InvalidCelsiusException ex)
                {
                    MessageBox.Show(ex.Message, "Conversion Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Conversion Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unexpected Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTemperature.Text = "";
            rdoFtoC.Checked = true;
            lblResult.Text = "";
            txtTemperature.Focus();
        }
    }
}

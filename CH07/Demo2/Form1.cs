using System;
using System.Windows.Forms;

namespace Demo2_GradeCalculator
{
    public partial class GradeCalculatorForm : Form
    {
        public GradeCalculatorForm()
        {
            InitializeComponent();
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

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal value = Convert.ToDecimal(textBox.Text);
            if (value < min || value > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // ---- Boolean AND Chain ----
        private bool IsValidData()
        {
            return
                IsPresent(txtHomework, "Homework") &&
                IsDecimal(txtHomework, "Homework") &&
                IsWithinRange(txtHomework, "Homework", 0, 100) &&
                IsPresent(txtMidterm, "Midterm") &&
                IsDecimal(txtMidterm, "Midterm") &&
                IsWithinRange(txtMidterm, "Midterm", 0, 100) &&
                IsPresent(txtFinal, "Final") &&
                IsDecimal(txtFinal, "Final") &&
                IsWithinRange(txtFinal, "Final", 0, 100);
        }

        private string GetLetterGrade(decimal average)
        {
            if (average >= 90) return "A";
            if (average >= 80) return "B";
            if (average >= 70) return "C";
            if (average >= 60) return "D";
            return "F";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal hw = Convert.ToDecimal(txtHomework.Text);
                decimal mid = Convert.ToDecimal(txtMidterm.Text);
                decimal fin = Convert.ToDecimal(txtFinal.Text);

                decimal average = hw * 0.30m + mid * 0.30m + fin * 0.40m;
                string letter = GetLetterGrade(average);

                lblResult.Text = $"Average: {average:f2}   Grade: {letter}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHomework.Text = "";
            txtMidterm.Text = "";
            txtFinal.Text = "";
            lblResult.Text = "";
            txtHomework.Focus();
        }
    }
}

namespace CH06_Part1_Demo2
{
    public partial class LoanApprovalForm : Form
    {
        public LoanApprovalForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            // TryParse returns true if successful, false if not.
            bool validScore = int.TryParse(txtCreditScore.Text, out int creditScore);
            bool validIncome = double.TryParse(txtIncome.Text, out double income);

            // Check if BOTH inputs are valid
            if (validScore && validIncome)
            {
                // Inputs are good, proceed with logic
                bool approved = IsLoanApproved(creditScore, income);

                if (approved)
                {
                    lblResult.Text = "Approved";
                    lblResult.ForeColor = System.Drawing.Color.Green; // Optional: Visual cue
                }
                else
                {
                    lblResult.Text = "Denied";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                //Handle invalid data (e.g. user typed "abc" or left it blank)
                lblResult.Text = "Invalid Input: Please enter numeric values.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
        private bool IsLoanApproved(int creditScore, double income)
        {
            if (creditScore >= 700 && income >= 40000)
            {
                return true;
            }
            else if (creditScore < 700 && income >= 75000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ResetForm()
        {
            // 1. Clear the TextBoxes
            txtCreditScore.Clear();
            txtIncome.Clear();

            // 2. Clear/Reset the result label
            lblResult.Text = "";
            // Optional: Reset color to black since it may be red
            lblResult.ForeColor = System.Drawing.Color.Black;

            // 3. Put the cursor back in the first box
            txtCreditScore.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // This single method handles the event for ANY TextBox you connect it to
        private void TextBox_Enter(object sender, EventArgs e)
        {
            // 1. Identify which text box triggered the event
            TextBox tb = sender as TextBox;

            // 2. If it is a valid text box, select all text
            if (tb != null)
            {
                tb.SelectAll();
            }
        }
    }
}

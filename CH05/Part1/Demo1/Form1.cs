namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckLoan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCreditScore.Text, out int creditScore)
                && int.TryParse(txtIncome.Text, out int annualIncome))
            {
                if ((creditScore >= 700 && annualIncome >= 40000)
                    || (creditScore < 700 && annualIncome >= 75000))
                {
                    lblResult.Text = "Approved";
                }
                else
                {
                    lblResult.Text = "Denied";
                }
            }
            else
            {
                lblErrorResult.Text = "Please enter both a Credit Score and an Annual Income";
                lblErrorResult.ForeColor = System.Drawing.Color.Red;
            }




        }
    }
}

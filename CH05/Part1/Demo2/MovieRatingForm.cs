namespace Lab2
{
    public partial class MovieRatingForm : Form
    {
        public MovieRatingForm()
        {
            InitializeComponent();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Black;

            if (int.TryParse(txtAudienceScore.Text, out int audienceScore))
            {
                lblResult.Text = audienceScore switch
                {
                    >= 90 => "Must See!",
                    >= 80 => "Excellant",
                    >= 70 => "Good",
                    >= 60 => "Average",
                    >= 50 => "Below Average",
                    _ => "Skip It"
                };
            }
            else
            {
                lblResult.Text = "Please enter a valid Audience Score";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}

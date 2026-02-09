namespace CH06_Part2_Demo3
{
    public partial class ScoreParserForm : Form
    {
        public ScoreParserForm()
        {
            InitializeComponent();
        }
        // -------------------------------------------------------
        // Method: ParseScore
        // Accepts a score string in various formats (e.g., "85",
        // "92.5%", "78 points") and returns a result message.
        // Strips known suffixes, validates the number, and checks range.
        // -------------------------------------------------------
        private string ParseScore(string scoreInput)
        {
            // Step 1: Strip known suffixes and symbols
            string cleaned = scoreInput.Replace("%", "")
                                       .Replace("points", "")
                                       .Trim();

            // Step 2: Try to parse the cleaned string as a double
            if (!double.TryParse(cleaned, out double score))
            {
                return "Invalid score";
            }

            // Step 3: Check if the score is in the valid range
            if (score < 0 || score > 100)
            {
                return "Score must be between 0 and 100";
            }

            // Step 4: Return success message formatted to 1 decimal place
            return $"Score of {score:F1} recorded!";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Call the method and display the result
            string result = ParseScore(txtScore.Text);
            lblResult.Text = result;
        }
    }
}

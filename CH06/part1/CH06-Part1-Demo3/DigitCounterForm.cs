namespace CH06_Part1_Demo3
{
    public partial class DigitCounterForm : Form
    {
        public DigitCounterForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // Get the phrase from the text box
            string phrase = txtPhrase.Text;

            // Call the method and get the count
            int count = CountDigits(phrase);

            // Display the result
            lblResult.Text = "There are " + count + " digits in your phrase";
        }

        // Method that accepts a phrase and returns the number of digits
        // Counts all digits 0-9
        private int CountDigits(string phrase)
        {
            int count = 0;

            // Loop through each character in the phrase
            for (int i = 0; i < phrase.Length; i++)
            {
                char c = phrase[i];

                // Check if it's a digit using a switch statement
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        count++;
                        break;
                }
            }

            return count;
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

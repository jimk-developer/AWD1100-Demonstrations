using static System.Net.Mime.MediaTypeNames;

namespace Demo5
{
    public partial class DigitCounterForm : Form
    {
        public DigitCounterForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int digitCount = 0;
            string text = txtInput.Text;

            // Loop through each character in the text
            for (int i = 0; i < text.Length; i++)
            {
                // Get the current character using Substring
                string currentChar = text.Substring(i, 1);

                // Use switch to check if it's a digit
                switch (currentChar)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        digitCount++;
                        break;
                    default:
                        // Not a digit - do nothing
                        break;
                }
            }

            lblResult.Text = digitCount.ToString();
        }
    }
}

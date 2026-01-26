namespace CH08_Demo5
{
    public partial class PhoneNumberFormatterForm : Form
    {
        public PhoneNumberFormatterForm()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            // Get the input from the text box
            string input = txtPhone.Text;

            // First, extract only the digits from the input
            string digitsOnly = "";

            // Loop through each character in the input string
            for (int i = 0; i < input.Length; i++)
            {
                // Get the current character using array-style access
                char currentChar = input[i];

                // Check if this character is a digit
                if (Char.IsDigit(currentChar))
                {
                    // Add the digit to our result string
                    digitsOnly = digitsOnly + currentChar;
                }
                // Non-digits (spaces, dashes, dots, parentheses) are ignored
            }

            // Now format based on how many digits we have
            if (digitsOnly.Length == 10)
            {
                // Standard 10-digit phone number
                // Format as (XXX) XXX-XXXX 3142227777
                string areaCode = digitsOnly.Substring(0, 3);
                string prefix = digitsOnly.Substring(3, 3);
                string lineNumber = digitsOnly.Substring(6, 4);

                lblFormatted.Text = "(" + areaCode + ") " + prefix + "-" + lineNumber;
            }
            else if (digitsOnly.Length == 7)
            {
                // 7-digit phone number (no area code)
                // Format as XXX-XXXX
                string prefix = digitsOnly.Substring(0, 3);
                string lineNumber = digitsOnly.Substring(3, 4);

                lblFormatted.Text = prefix + "-" + lineNumber;
            }
            else if (digitsOnly.Length == 11 && digitsOnly[0] == '1')
            {
                // 11-digit with country code
                // Format as 1 (XXX) XXX-XXXX
                string areaCode = digitsOnly.Substring(1, 3);
                string prefix = digitsOnly.Substring(4, 3);
                string lineNumber = digitsOnly.Substring(7, 4);

                lblFormatted.Text = "1 (" + areaCode + ") " + prefix + "-" + lineNumber;
            }
            else
            {
                // Invalid number of digits
                lblFormatted.Text = "Invalid phone number";
            }
        }
    }
}

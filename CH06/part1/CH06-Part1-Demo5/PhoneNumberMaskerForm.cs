namespace CH06_Part1_Demo5
{
    public partial class PhoneNumberMaskerForm : Form
    {
        public PhoneNumberMaskerForm()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            // Get the phone number text
            string rawInput = txtPhone.Text;

            // 1. Check if the input is a valid number using long.TryParse
            // We use 'long' because phone numbers (10 digits) are too big for 'int'
            if (long.TryParse(rawInput, out long validNumber))
            {

                // Call the method to mask the number
                // Note: We usually pass the original string 'rawInput' to the masking function
                string masked = MaskNumber(rawInput, '*', 4);

                // Display the result
                lblMasked.Text = masked;
                lblMasked.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                // --- INVALID DATA (Contains letters, symbols, or is empty) ---
                lblMasked.Text = "Invalid Phone Number";
                lblMasked.ForeColor = System.Drawing.Color.Red;
            }
        }
        // Method that masks a string, preserving the last N digits
        // Accepts: unmasked string, replacement character, number of digits to preserve
        // Returns: the masked string
        // Preserves spaces and dashes, replaces digits and letters
        private static string MaskNumber(string unmasked, char replacementChar, int numDigitsToPreserve)
        {
            // First, count how many digits are in the string
            int digitCount = 0;
            for (int i = 0; i < unmasked.Length; i++)
            {
                if (Char.IsDigit(unmasked[i]) || Char.IsLetter(unmasked[i]))
                {
                    digitCount++;
                }
            }

            // Calculate how many digits to mask (all except the last N)
            int digitsToMask = digitCount - numDigitsToPreserve;

            // If there are fewer digits than we want to preserve, don't mask anything
            if (digitsToMask < 0)
            {
                digitsToMask = 0;
            }

            // Build the masked string
            string masked = "";
            int digitsSeen = 0;

            for (int i = 0; i < unmasked.Length; i++)
            {
                char c = unmasked[i];

                // Check if it's a digit or letter
                if (Char.IsDigit(c) || Char.IsLetter(c))
                {
                    digitsSeen++;

                    // If we haven't reached the preserve point yet, mask it
                    if (digitsSeen <= digitsToMask)
                    {
                        masked += replacementChar;
                    }
                    else
                    {
                        // Preserve this digit
                        masked += c;
                    }
                }
                else
                {
                    // It's a space, dash, or other character - preserve it
                    masked += c;
                }
            }

            return masked;
        }
    }
}

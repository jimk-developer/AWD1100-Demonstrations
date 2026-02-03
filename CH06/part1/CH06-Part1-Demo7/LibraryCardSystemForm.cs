namespace CH06_Part1_Demo7
{
    public partial class LibraryCardSystemForm : Form
    {
        // Parallel arrays for user data
        // Concept: Parallel arrays use the same index 'i' to link data across different arrays.
        private readonly string[] cardNumbers = { "LIB001", "LIB002", "LIB003" };
        private readonly string[] pins = { "1111", "2222", "3333" };
        private readonly string[] names = { "Alice Smith", "Bob Jones", "Carol Davis" };
        private readonly int[] booksCheckedOut = { 2, 0, 5 };

        // Track the currently logged in user (-1 means no one logged in)
        int currentUserIndex = -1;

        public LibraryCardSystemForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cardNum = txtCardNumber.Text;
            string pin = txtPin.Text;

            Login(cardNum, pin);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Use TryParse to validate input before processing
            // We also check 'numBooks > 0' to prevent checking out negative books
            if (int.TryParse(txtBooks.Text, out int numBooks) && numBooks > 0)
            {
                CheckoutBooks(numBooks);
            }
            else
            {
                lblMessage.Text = "Please enter a valid positive number.";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBooks.Text, out int numBooks) && numBooks > 0)
            {
                ReturnBooks(numBooks);
            }
            else
            {
                lblMessage.Text = "Please enter a valid positive number.";
                lblMessage.ForeColor = Color.Red;
            }
        }

        // Method that handles user login
        private void Login(string cardNum, string pin)
        {
            bool found = false;

            for (int i = 0; i < cardNumbers.Length; i++)
            {
                // Check if both Card Number AND Pin match
                if (cardNumbers[i] == cardNum && pins[i] == pin)
                {
                    currentUserIndex = i; // Save which user is logged in
                    found = true;

                    // MODERN SYNTAX: String Interpolation ($"...")
                    // Much cleaner than: "Welcome, " + names[i] + "!"
                    lblMessage.Text = $"Welcome, {names[i]}!";
                    lblBooksOut.Text = $"Books checked out: {booksCheckedOut[i]}";

                    // Reset color to black in case it was red from an error
                    lblMessage.ForeColor = Color.Black;
                    break; // Exit the loop once found
                }
            }

            if (!found)
            {
                currentUserIndex = -1;
                lblMessage.Text = "Invalid card number or PIN";
                lblMessage.ForeColor = Color.Red;
                lblBooksOut.Text = "";
            }
        }

        private void Logout()
        {
            currentUserIndex = -1;
            lblMessage.Text = "You have been logged out";
            lblBooksOut.Text = "";

            // Optional: Clear the text boxes for the next user
            txtCardNumber.Clear();
            txtPin.Clear();
            txtBooks.Clear();
        }

        private void CheckoutBooks(int numBooks)
        {
            if (currentUserIndex == -1)
            {
                lblMessage.Text = "Please log in first";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            // MODERN SYNTAX: Compound Assignment (+=)
            // Same as: booksCheckedOut[currentUserIndex] = booksCheckedOut[currentUserIndex] + numBooks;
            booksCheckedOut[currentUserIndex] += numBooks;

            lblMessage.Text = $"Checked out {numBooks} book(s)";
            lblMessage.ForeColor = Color.Green;
            lblBooksOut.Text = $"Books checked out: {booksCheckedOut[currentUserIndex]}";
        }

        private void ReturnBooks(int numBooks)
        {
            if (currentUserIndex == -1)
            {
                lblMessage.Text = "Please log in first";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            // Logical Check: Do they actually have this many books to return?
            if (numBooks > booksCheckedOut[currentUserIndex])
            {
                lblMessage.Text = "You cannot return more books than you have!";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            // MODERN SYNTAX: Compound Assignment (-=)
            booksCheckedOut[currentUserIndex] -= numBooks;

            lblMessage.Text = $"Returned {numBooks} book(s)";
            lblMessage.ForeColor = Color.Green;
            lblBooksOut.Text = $"Books checked out: {booksCheckedOut[currentUserIndex]}";
        }
    }
}

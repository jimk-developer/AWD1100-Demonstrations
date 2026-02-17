using System;
using System.Windows.Forms;

namespace Demo3_LibraryCard
{
    public partial class Form1 : Form
    {
        // Array of library cards
        private LibraryCard[] cards = new LibraryCard[10];
        private int cardCount = 0;

        // Currently logged in card
        private LibraryCard activeCard = null;

        public Form1()
        {
            InitializeComponent();
            LoadSampleCards();
            UpdateUIState();
        }

        // Pre-load 5 library cards
        private void LoadSampleCards()
        {
            cards[0] = new LibraryCard("LIB001", "1234", "John Smith");
            cards[0].BooksCheckedOut = 2;
            
            cards[1] = new LibraryCard("LIB002", "5678", "Jane Doe");
            cards[1].BooksCheckedOut = 0;
            
            cards[2] = new LibraryCard("LIB003", "1111", "Bob Wilson");
            cards[2].BooksCheckedOut = 3;
            
            cards[3] = new LibraryCard("LIB004", "2222", "Alice Brown");
            cards[3].BooksCheckedOut = 1;
            
            cards[4] = new LibraryCard("LIB005", "3333", "Charlie Davis");
            cards[4].BooksCheckedOut = 5;
            
            cardCount = 5;
        }

        // Login method
        private void Login(string cardNumber, string pin)
        {
            // First logout any existing user
            if (activeCard != null)
            {
                Logout();
            }

            // Search for card
            for (int i = 0; i < cardCount; i++)
            {
                if (cards[i].CardNumber.ToUpper() == cardNumber.ToUpper())
                {
                    // Found card, check PIN
                    if (cards[i].Pin == pin)
                    {
                        // Login successful
                        activeCard = cards[i];
                        lblResult.Text = $"Welcome, {activeCard.HolderName}!\n\n" +
                                        $"Card Number: {activeCard.CardNumber}\n" +
                                        $"Books Checked Out: {activeCard.BooksCheckedOut}";
                        UpdateUIState();
                        return;
                    }
                    else
                    {
                        lblResult.Text = "Invalid PIN";
                        return;
                    }
                }
            }

            lblResult.Text = "Card number not found";
        }

        // Logout method
        private void Logout()
        {
            activeCard = null;
            lblResult.Text = "You have been logged out.";
            txtCardNumber.Clear();
            txtPin.Clear();
            UpdateUIState();
        }

        // Check out a book
        private void CheckOut()
        {
            if (activeCard == null)
            {
                lblResult.Text = "Please login first";
                return;
            }

            if (activeCard.BooksCheckedOut >= 5)
            {
                lblResult.Text = $"Maximum books reached!\n\n" +
                                $"You have {activeCard.BooksCheckedOut} books.\n" +
                                $"Please return a book first.";
                return;
            }

            activeCard.CheckOutBook();
            lblResult.Text = $"Book checked out successfully!\n\n" +
                            $"{activeCard.HolderName}\n" +
                            $"Books Checked Out: {activeCard.BooksCheckedOut}";
        }

        // Return a book
        private void Return()
        {
            if (activeCard == null)
            {
                lblResult.Text = "Please login first";
                return;
            }

            if (activeCard.BooksCheckedOut <= 0)
            {
                lblResult.Text = $"No books to return!\n\n" +
                                $"You have 0 books checked out.";
                return;
            }

            activeCard.ReturnBook();
            lblResult.Text = $"Book returned successfully!\n\n" +
                            $"{activeCard.HolderName}\n" +
                            $"Books Checked Out: {activeCard.BooksCheckedOut}";
        }

        // Update UI based on login state
        private void UpdateUIState()
        {
            bool loggedIn = (activeCard != null);

            // Login section
            txtCardNumber.Enabled = !loggedIn;
            txtPin.Enabled = !loggedIn;
            btnLogin.Enabled = !loggedIn;

            // Actions section
            btnCheckOut.Enabled = loggedIn;
            btnReturn.Enabled = loggedIn;
            btnLogout.Enabled = loggedIn;

            if (!loggedIn)
            {
                txtCardNumber.Focus();
            }
        }

        // Event handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text))
            {
                lblResult.Text = "Please enter a card number";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPin.Text))
            {
                lblResult.Text = "Please enter a PIN";
                return;
            }

            Login(txtCardNumber.Text.Trim(), txtPin.Text.Trim());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}

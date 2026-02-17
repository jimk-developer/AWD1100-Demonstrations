using System;

namespace Demo3_LibraryCard
{
    public class LibraryCard
    {
        // Private fields
        private string _cardNumber;
        private string _pin;
        private string _holderName;
        private int _booksCheckedOut;

        // Constructor
        public LibraryCard(string cardNumber, string pin, string holderName)
        {
            _cardNumber = cardNumber;
            _pin = pin;
            _holderName = holderName;
            _booksCheckedOut = 0;
        }

        // Read-only properties
        public string CardNumber
        {
            get { return _cardNumber; }
        }

        public string Pin
        {
            get { return _pin; }
        }

        public string HolderName
        {
            get { return _holderName; }
        }

        // Read/write property for books checked out
        public int BooksCheckedOut
        {
            get { return _booksCheckedOut; }
            set { _booksCheckedOut = value; }
        }

        // Check out a book
        public void CheckOutBook()
        {
            _booksCheckedOut++;
        }

        // Return a book
        public void ReturnBook()
        {
            _booksCheckedOut--;
        }
    }
}

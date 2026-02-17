using System;

namespace Demo2_ContactManager
{
    public class Contact
    {
        // Private fields
        private string _id;
        private string _name;
        private string _phone;
        private string _email;

        // Constructor
        public Contact(string id, string name, string phone, string email)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _email = email;
        }

        // Read-only property for ID
        public string Id
        {
            get { return _id; }
        }

        // Read/write properties for Name, Phone, Email
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Display method returns formatted string
        public string Display()
        {
            return $"Contact ID: {_id}\n" +
                   $"Name: {_name}\n" +
                   $"Phone: {_phone}\n" +
                   $"Email: {_email}";
        }
    }
}

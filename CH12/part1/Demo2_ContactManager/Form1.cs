using System;
using System.Windows.Forms;

namespace Demo2_ContactManager
{
    public partial class Form1 : Form
    {
        // Array to store contacts and counter
        private Contact[] contacts = new Contact[20];
        private int contactCount = 0;
        
        // Admin password for delete operations
        private string adminPassword = "admin123";

        // Track currently displayed contact for updates
        private int currentContactIndex = -1;

        public Form1()
        {
            InitializeComponent();
            LoadSampleContacts();
        }

        // Pre-load 5 sample contacts
        private void LoadSampleContacts()
        {
            contacts[0] = new Contact("C001", "John Smith", "555-0101", "john.smith@email.com");
            contacts[1] = new Contact("C002", "Jane Doe", "555-0102", "jane.doe@email.com");
            contacts[2] = new Contact("C003", "Bob Wilson", "555-0103", "bob.wilson@email.com");
            contacts[3] = new Contact("C004", "Alice Brown", "555-0104", "alice.brown@email.com");
            contacts[4] = new Contact("C005", "Charlie Davis", "555-0105", "charlie.davis@email.com");
            contactCount = 5;
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                lblResult.Text = "Please enter a Contact ID";
                ClearFields();
                currentContactIndex = -1;
                return;
            }

            string searchId = txtSearchId.Text.Trim().ToUpper();
            int index = FindContact(searchId);

            if (index >= 0)
            {
                // Contact found - display in fields
                currentContactIndex = index;
                txtName.Text = contacts[index].Name;
                txtPhone.Text = contacts[index].Phone;
                txtEmail.Text = contacts[index].Email;
                lblResult.Text = "Contact found!\n\n" + contacts[index].Display();
            }
            else
            {
                lblResult.Text = $"Contact '{searchId}' not found";
                ClearFields();
                currentContactIndex = -1;
            }
        }

        // Find contact by ID
        private int FindContact(string id)
        {
            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].Id.ToUpper() == id.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }

        // Generate next contact ID
        private string GetNextId()
        {
            int nextNum = contactCount + 1;
            return $"C{nextNum:D3}";
        }

        // Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblResult.Text = "Please enter a name";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblResult.Text = "Please enter a phone number";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblResult.Text = "Please enter an email address";
                return;
            }

            // Check if array is full
            if (contactCount >= contacts.Length)
            {
                lblResult.Text = "Contact list is full! Maximum 20 contacts.";
                return;
            }

            // Create new contact with auto-generated ID
            string newId = GetNextId();
            Contact newContact = new Contact(
                newId,
                txtName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtEmail.Text.Trim()
            );

            contacts[contactCount] = newContact;
            contactCount++;

            lblResult.Text = $"Contact {newId} added successfully!\n\n" + newContact.Display();

            ClearFields();
            txtSearchId.Clear();
            currentContactIndex = -1;
            txtSearchId.Focus();
        }

        // Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentContactIndex < 0)
            {
                lblResult.Text = "Please search for a contact first";
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblResult.Text = "Please enter a name";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblResult.Text = "Please enter a phone number";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblResult.Text = "Please enter an email address";
                return;
            }

            // Update the contact's properties
            contacts[currentContactIndex].Name = txtName.Text.Trim();
            contacts[currentContactIndex].Phone = txtPhone.Text.Trim();
            contacts[currentContactIndex].Email = txtEmail.Text.Trim();

            lblResult.Text = $"Contact {contacts[currentContactIndex].Id} updated!\n\n" + 
                           contacts[currentContactIndex].Display();
        }

        // Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentContactIndex < 0)
            {
                lblResult.Text = "Please search for a contact first";
                return;
            }

            // Prompt for admin password
            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter admin password to delete:", 
                "Delete Confirmation", 
                "");

            if (inputPassword != adminPassword)
            {
                lblResult.Text = "Incorrect password. Delete cancelled.";
                return;
            }

            string deletedId = contacts[currentContactIndex].Id;

            // Shift remaining contacts down
            for (int i = currentContactIndex; i < contactCount - 1; i++)
            {
                contacts[i] = contacts[i + 1];
            }
            contacts[contactCount - 1] = null;
            contactCount--;

            lblResult.Text = $"Contact {deletedId} deleted successfully";
            ClearFields();
            txtSearchId.Clear();
            currentContactIndex = -1;
            txtSearchId.Focus();
        }

        // Clear input fields
        private void ClearFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}

namespace EFDemoLINQSQL
{
    public partial class Form1 : Form
    {
        CustomerContext customerDb;
        List<Customer> customerList;
        private int _customerUpdateId;
        private Customer? updateCustomer;

        public Form1()
        {
            customerDb = new();
            InitializeComponent();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            customerList = customerDb.Customers.Select(c => c).ToList();
            lblResult.Text = "";
            cboCustomerIds.Items.Clear();
            cboCustomerToUpdate.Items.Clear();

            foreach (Customer customer in customerList)
            {
                lblResult.Text += customer.ToString();
                cboCustomerIds.Items.Add(customer.CustomerID);
                cboCustomerToUpdate.Items.Add(customer.CustomerID);
            }
        }

        private void btnSearchMin_Click(object sender, EventArgs e)
        {
            lblSearchResult.Text = "";

            float minBudgetSearch = float.Parse(txtMinBudget.Text);
            customerList = customerDb
                .Customers
                .OrderBy(c => c.CustomerName)
                .Where(c => c.Budget >= minBudgetSearch)
                .Select(c => c)
                .ToList();

            foreach (Customer customer in customerList)
            {
                lblSearchResult.Text += customer.ToString();
            }
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            lblSearchResult.Text = "";

            int customerId = int.Parse(txtCustomerId.Text);
            Customer? customer = customerDb.Customers.Where(c => c.CustomerID == customerId).FirstOrDefault();

            if (customer != null)
            {
                lblSearchResult.Text = customer.ToString();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer addCustomer = new() { Budget = double.Parse(txtAddBudget.Text), CustomerName = txtAddName.Text };

            try
            {
                customerDb.Customers.Add(addCustomer);
                customerDb.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            ShowCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int idForDeletion = (int)cboCustomerIds.SelectedItem;

            Customer? customerToDelete = customerDb.Customers.Find(idForDeletion);

            if (customerToDelete != null)
            {
                try
                {
                    customerDb.Customers.Remove(customerToDelete);
                    customerDb.SaveChanges();
                    lblDelete.Text = "Customer Deleted!";
                    ShowCustomers();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void cboCustomerToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerUpdateId = (int)cboCustomerToUpdate.SelectedItem;

            updateCustomer = customerDb.Customers.Find(_customerUpdateId);

            if (updateCustomer != null)
            {
                txtNameToUpdate.Text = updateCustomer.CustomerName;
                txtBudgetToUpdate.Text = updateCustomer.Budget.ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (updateCustomer != null)
            {
                updateCustomer.CustomerName = txtNameToUpdate.Text;
                updateCustomer.Budget = double.Parse(txtBudgetToUpdate.Text);

                try
                {
                    customerDb.Customers.Update(updateCustomer);
                    customerDb.SaveChanges();
                    lblCustomerUpdated.Text = $"{updateCustomer.CustomerName} has been updated!";
                }
                catch (Exception ex)
                {

                }

                ShowCustomers();
            }
        }
    }
}

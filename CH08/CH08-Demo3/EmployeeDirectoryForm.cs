namespace CH08_Demo3
{
    public partial class EmployeeDirectoryForm : Form
    {
        // Declare parallel arrays at class level for employee data
        string[] names = {
        "Alice Johnson",
        "Bob Martinez",
        "Carol Williams",
        "David Chen",
        "Emma Thompson"
    };

        string[] departments = {
        "Engineering",
        "Marketing",
        "Human Resources",
        "Engineering",
        "Finance"
    };

        string[] extensions = {
        "x1001",
        "x1002",
        "x1003",
        "x1004",
        "x1005"
    };

        public EmployeeDirectoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the search term and convert to lowercase
            string searchTerm = txtSearch.Text.ToLower();

            // Variable to track if we found a match
            bool found = false;

            // Linear search through parallel arrays
            for (int i = 0; i < names.Length; i++)
            {
                // Check if name contains the search term (case-insensitive)
                if (names[i].ToLower().Contains(searchTerm))
                {
                    // Found a match - display the information
                    lblName.Text = names[i];
                    lblDepartment.Text = departments[i];
                    lblExtension.Text = extensions[i];
                    found = true;
                    break;
                }

                // Check if department contains the search term (case-insensitive)
                if (departments[i].ToLower().Contains(searchTerm))
                {
                    // Found a match - display the information
                    lblName.Text = names[i];
                    lblDepartment.Text = departments[i];
                    lblExtension.Text = extensions[i];
                    found = true;
                    break;
                }
            }

            // If no match was found, display error message
            if (!found)
            {
                lblName.Text = "Employee Not Found";
                lblDepartment.Text = "Employee Not Found";
                lblExtension.Text = "Employee Not Found";
            }
        }
    }
}

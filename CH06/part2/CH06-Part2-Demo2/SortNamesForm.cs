namespace CH06_Part2_Demo2
{
    public partial class SortNamesForm : Form
    {
        public SortNamesForm()
        {
            InitializeComponent();
        }
        // -------------------------------------------------------
        // Method: SortNames
        // Sorts a string array in place (alphabetical order).
        // Because arrays are reference types, the original array
        // is modified - no need for ref or a return value.
        // -------------------------------------------------------
        private void SortNames(string[] names)
        {
            Array.Sort(names);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtNames.Text.Trim();

            // Validate - must enter something
            if (input == "")
            {
                lblResult.Text = "Error: Please enter at least one name";
                return;
            }

            // Split the input by commas into an array
            string[] names = input.Split(',');

            // Trim whitespace from each name
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim();
            }

            // Call the method to sort the array
            SortNames(names);

            // Display the sorted names, one per line
            // string.Join combines array elements with a separator
            lblResult.Text = string.Join("\n", names);
        }
    }
}

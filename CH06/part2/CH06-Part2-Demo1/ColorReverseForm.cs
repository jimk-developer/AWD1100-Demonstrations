namespace CH06_Part2_Demo1
{
    public partial class ColorReverseForm : Form
    {
        public ColorReverseForm()
        {
            InitializeComponent();
        }
        // -------------------------------------------------------
        // Method: RotateColors
        // Rotates three string values one position forward.
        // After the call: color1 = old color2, color2 = old color3,
        //                 color3 = old color1
        // Uses ref so changes are reflected back in the calling code.
        // -------------------------------------------------------
        private void ReverseColors(ref string color1, ref string color2, ref string color3)
        {
            // Only need to swap the first and last values
            string temp = color1;
            color1 = color3;
            color3 = temp;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            // Read values from text boxes and trim whitespace
            string c1 = txtColor1.Text.Trim();
            string c2 = txtColor2.Text.Trim();
            string c3 = txtColor3.Text.Trim();

            // Validate - all three fields must have a value
            if (c1 == "" || c2 == "" || c3 == "")
            {
                lblResult1.Text = "Error: Please enter all three colors";
                lblResult2.Text = "";
                lblResult3.Text = "";
                return;
            }

            // Call the method - note the ref keyword is required at the call site too
            ReverseColors(ref c1, ref c2, ref c3);

            // Display the reversed values
            lblResult1.Text = c1;
            lblResult2.Text = c2;
            lblResult3.Text = c3;
        }
    }
}

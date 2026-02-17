using System;
using System.Windows.Forms;

namespace Demo6_PaintEstimator
{
    public partial class Form1 : Form
    {
        // Array of walls and counter
        private Wall[] walls = new Wall[15];
        private int wallCount = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        // Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate room name
            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                lblError.Text = "Please enter a room name";
                txtRoomName.Focus();
                return;
            }

            // Validate height
            int height;
            if (!int.TryParse(txtHeight.Text, out height) || height <= 0)
            {
                lblError.Text = "Please enter a valid height";
                txtHeight.Focus();
                return;
            }

            // Validate width
            int width;
            if (!int.TryParse(txtWidth.Text, out width) || width <= 0)
            {
                lblError.Text = "Please enter a valid width";
                txtWidth.Focus();
                return;
            }

            // Check if array is full
            if (wallCount >= walls.Length)
            {
                lblError.Text = "Maximum 15 walls reached!";
                return;
            }

            // Create new Wall object
            Wall newWall = new Wall(
                txtRoomName.Text.Trim(),
                height,
                width
            );

            // Add to array
            walls[wallCount] = newWall;
            wallCount++;

            // Clear error and update display
            lblError.Text = "";
            UpdateDisplay();

            // Clear fields and set focus
            txtRoomName.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
            txtRoomName.Focus();
        }

        // Update the display with all walls
        private void UpdateDisplay()
        {
            if (wallCount == 0)
            {
                lblResult.Text = "No walls added yet.\n\n" +
                                "Enter wall dimensions and click Add.\n\n" +
                                "Formula:\n" +
                                "• Area = Height × Width\n" +
                                "• Gallons = (Area ÷ 350) + 1\n" +
                                "  (1 gallon per 350 sq ft + 1 for touch-ups)";
                lblTotal.Text = "";
                return;
            }

            string output = "Walls Added:\n";
            output += "─────────────────────────────\n\n";

            int totalGallons = 0;
            int totalArea = 0;

            for (int i = 0; i < wallCount; i++)
            {
                output += $"{i + 1}. {walls[i].Display()}\n";
                output += $"   Area: {walls[i].Area} sq ft\n\n";
                totalGallons += walls[i].Gallons;
                totalArea += walls[i].Area;
            }

            lblResult.Text = output;

            lblTotal.Text = $"TOTAL: {wallCount} wall(s)\n" +
                           $"Total Area: {totalArea} sq ft\n" +
                           $"Total Paint: {totalGallons} gallons";
        }

        // Clear all button click
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // Reset array
            walls = new Wall[15];
            wallCount = 0;

            // Clear fields
            txtRoomName.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
            lblError.Text = "";

            // Update display
            UpdateDisplay();
            txtRoomName.Focus();
        }
    }
}

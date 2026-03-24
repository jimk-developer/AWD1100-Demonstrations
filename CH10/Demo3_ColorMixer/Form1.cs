using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo3_ColorMixer
{
    public partial class Form1 : Form
    {
        // Array of panels for easy indexing
        private Panel[] _panels;

        // Track which panel currently has "focus" (our custom focus tracker)
        private int _focusedIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Store panels in an array arranged in a 3x3 grid
            _panels = new Panel[]
            {
                pnlColor1, pnlColor2, pnlColor3,
                pnlColor4, pnlColor5, pnlColor6,
                pnlColor7, pnlColor8, pnlColor9
            };

            // Wire up mouse and focus events for each panel
            foreach (Panel panel in _panels)
            {
                panel.Click += Panel_Click;
                panel.MouseEnter += Panel_MouseEnter;
                panel.MouseLeave += Panel_MouseLeave;
                panel.GotFocus += Panel_GotFocus;
                panel.LostFocus += Panel_LostFocus;
            }

            // Set initial focus
            _panels[0].Focus();
        }

        // MOUSE EVENT: Click toggles Red on/off
        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel.BackColor == Color.Red)
            {
                // Already red — toggle back to default
                // Restore to LightBlue if focused, otherwise White
                panel.BackColor = panel.Focused ? Color.LightBlue : Color.White;
                lblStatus.Text = $"Status: {panel.Name} unpainted (Click)";
            }
            else
            {
                panel.BackColor = Color.Red;
                lblStatus.Text = $"Status: {panel.Name} painted Red (Click)";
            }
        }

        // MOUSE EVENT: Hover changes panel to LightGreen (unless painted Red)
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            // Show hover color unless painted Red
            if (panel.BackColor != Color.Red)
            {
                panel.BackColor = Color.LightGreen;
            }

            lblStatus.Text = $"Status: Mouse entered {panel.Name}";
        }

        // MOUSE EVENT: Mouse leave restores appropriate color (unless painted)
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            // Only restore if not painted Red
            if (panel.BackColor != Color.Red)
            {
                // If this panel has focus, restore to LightBlue; otherwise White
                panel.BackColor = panel.Focused ? Color.LightBlue : Color.White;
            }
        }

        // FOCUS EVENT: Receiving focus changes panel to LightBlue
        private void Panel_GotFocus(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel.BackColor != Color.Red)
            {
                panel.BackColor = Color.LightBlue;
            }

            // Track which panel has focus
            for (int i = 0; i < _panels.Length; i++)
            {
                if (_panels[i] == panel)
                {
                    _focusedIndex = i;
                    //System.Diagnostics.Debug.WriteLine("_focusedIndex= " + _focusedIndex);

                    break;
                }
            }

            lblStatus.Text = $"Status: {panel.Name} received focus";
        }

        // FOCUS EVENT: Losing focus restores to White (unless painted)
        private void Panel_LostFocus(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel.BackColor != Color.Red)
            {
                panel.BackColor = Color.White;
            }
        }

        // KEYBOARD EVENT: W/A/S/D move focus through the 3x3 grid
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int row = _focusedIndex / 3;
            int col = _focusedIndex % 3;


            switch (e.KeyCode)
            {
                case Keys.W: // Up
                    if (row > 0) row--;
                    break;
                case Keys.S: // Down
                    if (row < 2) row++;
                    break;
                case Keys.A: // Left
                    if (col > 0) col--;
                    break;
                case Keys.D: // Right
                    if (col < 2) col++;
                    break;
                case Keys.R: // Reset all panels
                    foreach (Panel panel in _panels)
                    {
                        panel.BackColor = Color.White;
                    }
                    lblStatus.Text = "Status: All panels reset";
                    return;
            }

            int newIndex = row * 3 + col;
            _panels[newIndex].Focus();
            e.Handled = true;
        }
    }
}

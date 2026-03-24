using System;
using System.Numerics;
using System.Windows.Forms;

namespace Demo7_TeamRoster
{
    public partial class Form1 : Form
    {
        // Array of Team objects, each with its own List<Player>
        private Team[] _teams;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create teams with unique player lists
            Team thunderbolts = new Team("Thunderbolts");
            thunderbolts.AddPlayer(new Player("Alex Rivera", "Point Guard", 7));
            thunderbolts.AddPlayer(new Player("Marcus Chen", "Shooting Guard", 23));
            thunderbolts.AddPlayer(new Player("Jordan Wells", "Center", 50));

            Team wildcats = new Team("Wildcats");
            wildcats.AddPlayer(new Player("Sam Patel", "Forward", 11));
            wildcats.AddPlayer(new Player("Chris Nolan", "Midfielder", 8));
            wildcats.AddPlayer(new Player("Taylor Brooks", "Goalkeeper", 1));

            Team falcons = new Team("Falcons");
            falcons.AddPlayer(new Player("Morgan Lee", "Pitcher", 34));
            falcons.AddPlayer(new Player("Casey Kim", "Catcher", 12));

            _teams = new Team[] { thunderbolts, wildcats, falcons };

            // Populate ComboBox with teams
            foreach (Team team in _teams)
            {
                cboTeams.Items.Add(team.TeamName);
            }

            // Select the first team by default
            cboTeams.SelectedIndex = 0;
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshRosterDisplay();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a team first.", "No Team",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtPlayerName.Text.Trim();
            string position = txtPosition.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please enter a player name and position.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int jersey;
            if (!int.TryParse(txtJersey.Text, out jersey) || jersey < 0 || jersey > 99)
            {
                MessageBox.Show("Please enter a valid jersey number (0-99).", "Invalid Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to the currently selected team
            Team selectedTeam = _teams[cboTeams.SelectedIndex];
            selectedTeam.AddPlayer(new Player(name, position, jersey));

            // Clear inputs
            txtPlayerName.Text = "";
            txtPosition.Text = "";
            txtJersey.Text = "";

            RefreshRosterDisplay();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (cboTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a team first.", "No Team",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtRemoveName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a player name to remove.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Team selectedTeam = _teams[cboTeams.SelectedIndex];
            bool removed = selectedTeam.RemovePlayer(name);

            if (removed)
            {
                txtRemoveName.Text = "";
                RefreshRosterDisplay();
            }
            else
            {
                MessageBox.Show($"Player \"{name}\" was not found on {selectedTeam.TeamName}.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Refresh the RichTextBox with the selected team's roster
        private void RefreshRosterDisplay()
        {
            if (cboTeams.SelectedIndex < 0) return;

            Team selectedTeam = _teams[cboTeams.SelectedIndex];

            string display = $"Team: {selectedTeam.TeamName}\n";
            display += $"Players: {selectedTeam.Players.Count}\n";
            display += new string('=', 35) + "\n";

            for (int i = 0; i < selectedTeam.Players.Count; i++)
            {
                display += $"  {selectedTeam.Players[i].ToString()}\n";
            }

            rtbRoster.Text = display;
        }
    }
}

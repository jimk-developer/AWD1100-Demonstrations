namespace Demo7_TeamRoster
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.grpAddPlayer = new System.Windows.Forms.GroupBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblJersey = new System.Windows.Forms.Label();
            this.txtJersey = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.grpRemovePlayer = new System.Windows.Forms.GroupBox();
            this.lblRemoveName = new System.Windows.Forms.Label();
            this.txtRemoveName = new System.Windows.Forms.TextBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.rtbRoster = new System.Windows.Forms.RichTextBox();
            this.grpAddPlayer.SuspendLayout();
            this.grpRemovePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectTeam.Location = new System.Drawing.Point(15, 15);
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTeams.Location = new System.Drawing.Point(15, 40);
            this.cboTeams.Size = new System.Drawing.Size(260, 25);
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // grpAddPlayer
            // 
            this.grpAddPlayer.Controls.Add(this.lblPlayerName);
            this.grpAddPlayer.Controls.Add(this.txtPlayerName);
            this.grpAddPlayer.Controls.Add(this.lblPosition);
            this.grpAddPlayer.Controls.Add(this.txtPosition);
            this.grpAddPlayer.Controls.Add(this.lblJersey);
            this.grpAddPlayer.Controls.Add(this.txtJersey);
            this.grpAddPlayer.Controls.Add(this.btnAddPlayer);
            this.grpAddPlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpAddPlayer.Location = new System.Drawing.Point(15, 80);
            this.grpAddPlayer.Size = new System.Drawing.Size(260, 165);
            this.grpAddPlayer.Text = "Add Player";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(10, 25);
            this.lblPlayerName.Text = "Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(80, 22);
            this.txtPlayerName.Size = new System.Drawing.Size(165, 23);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(10, 58);
            this.lblPosition.Text = "Position:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(80, 55);
            this.txtPosition.Size = new System.Drawing.Size(165, 23);
            // 
            // lblJersey
            // 
            this.lblJersey.AutoSize = true;
            this.lblJersey.Location = new System.Drawing.Point(10, 91);
            this.lblJersey.Text = "Jersey #:";
            // 
            // txtJersey
            // 
            this.txtJersey.Location = new System.Drawing.Point(80, 88);
            this.txtJersey.Size = new System.Drawing.Size(80, 23);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(80, 122);
            this.btnAddPlayer.Size = new System.Drawing.Size(165, 30);
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // grpRemovePlayer
            // 
            this.grpRemovePlayer.Controls.Add(this.lblRemoveName);
            this.grpRemovePlayer.Controls.Add(this.txtRemoveName);
            this.grpRemovePlayer.Controls.Add(this.btnRemovePlayer);
            this.grpRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpRemovePlayer.Location = new System.Drawing.Point(15, 255);
            this.grpRemovePlayer.Size = new System.Drawing.Size(260, 65);
            this.grpRemovePlayer.Text = "Remove Player";
            // 
            // lblRemoveName
            // 
            this.lblRemoveName.AutoSize = true;
            this.lblRemoveName.Location = new System.Drawing.Point(10, 28);
            this.lblRemoveName.Text = "Name:";
            // 
            // txtRemoveName
            // 
            this.txtRemoveName.Location = new System.Drawing.Point(60, 25);
            this.txtRemoveName.Size = new System.Drawing.Size(100, 23);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(170, 23);
            this.btnRemovePlayer.Size = new System.Drawing.Size(75, 27);
            this.btnRemovePlayer.Text = "Remove";
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // rtbRoster
            // 
            this.rtbRoster.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbRoster.Location = new System.Drawing.Point(290, 15);
            this.rtbRoster.ReadOnly = true;
            this.rtbRoster.Size = new System.Drawing.Size(310, 305);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 336);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.grpAddPlayer);
            this.Controls.Add(this.grpRemovePlayer);
            this.Controls.Add(this.rtbRoster);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Roster Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddPlayer.ResumeLayout(false);
            this.grpAddPlayer.PerformLayout();
            this.grpRemovePlayer.ResumeLayout(false);
            this.grpRemovePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.GroupBox grpAddPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblJersey;
        private System.Windows.Forms.TextBox txtJersey;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.GroupBox grpRemovePlayer;
        private System.Windows.Forms.Label lblRemoveName;
        private System.Windows.Forms.TextBox txtRemoveName;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.RichTextBox rtbRoster;
    }
}

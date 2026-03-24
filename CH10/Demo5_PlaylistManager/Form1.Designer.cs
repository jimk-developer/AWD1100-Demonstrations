namespace Demo5_PlaylistManager
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
            this.grpAddSong = new System.Windows.Forms.GroupBox();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.grpRemoveSong = new System.Windows.Forms.GroupBox();
            this.lblRemoveTitle = new System.Windows.Forms.Label();
            this.txtRemoveTitle = new System.Windows.Forms.TextBox();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.rtbPlaylist = new System.Windows.Forms.RichTextBox();
            this.grpAddSong.SuspendLayout();
            this.grpRemoveSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddSong
            // 
            this.grpAddSong.Controls.Add(this.lblSongTitle);
            this.grpAddSong.Controls.Add(this.txtSongTitle);
            this.grpAddSong.Controls.Add(this.lblArtist);
            this.grpAddSong.Controls.Add(this.txtArtist);
            this.grpAddSong.Controls.Add(this.lblDuration);
            this.grpAddSong.Controls.Add(this.txtDuration);
            this.grpAddSong.Controls.Add(this.btnAddSong);
            this.grpAddSong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAddSong.Location = new System.Drawing.Point(15, 15);
            this.grpAddSong.Name = "grpAddSong";
            this.grpAddSong.Size = new System.Drawing.Size(260, 200);
            this.grpAddSong.Text = "Add Song";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Location = new System.Drawing.Point(10, 30);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Text = "Song Title:";
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(10, 52);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(235, 25);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(10, 82);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Text = "Artist:";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(10, 104);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(235, 25);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(10, 134);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Text = "Duration (min):";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(10, 156);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(120, 25);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(140, 154);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(105, 30);
            this.btnAddSong.Text = "Add";
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // grpRemoveSong
            // 
            this.grpRemoveSong.Controls.Add(this.lblRemoveTitle);
            this.grpRemoveSong.Controls.Add(this.txtRemoveTitle);
            this.grpRemoveSong.Controls.Add(this.btnRemoveSong);
            this.grpRemoveSong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRemoveSong.Location = new System.Drawing.Point(15, 225);
            this.grpRemoveSong.Name = "grpRemoveSong";
            this.grpRemoveSong.Size = new System.Drawing.Size(260, 100);
            this.grpRemoveSong.Text = "Remove Song";
            // 
            // lblRemoveTitle
            // 
            this.lblRemoveTitle.AutoSize = true;
            this.lblRemoveTitle.Location = new System.Drawing.Point(10, 30);
            this.lblRemoveTitle.Name = "lblRemoveTitle";
            this.lblRemoveTitle.Text = "Song Title:";
            // 
            // txtRemoveTitle
            // 
            this.txtRemoveTitle.Location = new System.Drawing.Point(10, 52);
            this.txtRemoveTitle.Name = "txtRemoveTitle";
            this.txtRemoveTitle.Size = new System.Drawing.Size(135, 25);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(155, 50);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(90, 30);
            this.btnRemoveSong.Text = "Remove";
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // rtbPlaylist
            // 
            this.rtbPlaylist.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbPlaylist.Location = new System.Drawing.Point(290, 15);
            this.rtbPlaylist.Name = "rtbPlaylist";
            this.rtbPlaylist.ReadOnly = true;
            this.rtbPlaylist.Size = new System.Drawing.Size(330, 310);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.grpAddSong);
            this.Controls.Add(this.grpRemoveSong);
            this.Controls.Add(this.rtbPlaylist);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddSong.ResumeLayout(false);
            this.grpAddSong.PerformLayout();
            this.grpRemoveSong.ResumeLayout(false);
            this.grpRemoveSong.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddSong;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.GroupBox grpRemoveSong;
        private System.Windows.Forms.Label lblRemoveTitle;
        private System.Windows.Forms.TextBox txtRemoveTitle;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.RichTextBox rtbPlaylist;
    }
}

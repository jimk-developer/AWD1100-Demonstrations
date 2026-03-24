using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Demo5_PlaylistManager
{
    public partial class Form1 : Form
    {
        // Playlist object using List<Song>
        private Playlist _playlist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create playlist with initial songs
            _playlist = new Playlist("My Favorites");

            _playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", 5.9));
            _playlist.AddSong(new Song("Hotel California", "Eagles", 6.5));
            _playlist.AddSong(new Song("Stairway to Heaven", "Led Zeppelin", 8.0));
            _playlist.AddSong(new Song("Imagine", "John Lennon", 3.1));

            // Display the playlist
            RefreshPlaylistDisplay();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            // Validate inputs
            string title = txtSongTitle.Text.Trim();
            string artist = txtArtist.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(artist))
            {
                MessageBox.Show("Please enter both a song title and artist.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double duration;
            if (!double.TryParse(txtDuration.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Please enter a valid duration in minutes.", "Invalid Duration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add song to the playlist
            _playlist.AddSong(new Song(title, artist, duration));

            // Clear input fields
            txtSongTitle.Text = "";
            txtArtist.Text = "";
            txtDuration.Text = "";

            // Refresh the display
            RefreshPlaylistDisplay();
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            string title = txtRemoveTitle.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a song title to remove.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool removed = _playlist.RemoveSong(title);

            if (removed)
            {
                txtRemoveTitle.Text = "";
                RefreshPlaylistDisplay();
            }
            else
            {
                MessageBox.Show($"Song \"{title}\" was not found in the playlist.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Refresh the RichTextBox with the current playlist
        private void RefreshPlaylistDisplay()
        {
            rtbPlaylist.Text = _playlist.ToString();
        }
    }
}

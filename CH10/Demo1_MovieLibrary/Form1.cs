using Microsoft.VisualBasic.Devices;
using System;
using System.Windows.Forms;

namespace Demo1_MovieLibrary
{
    public partial class Form1 : Form
    {
        // Array of Movie objects
        private Movie[] _movies;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Movie objects
            _movies = new Movie[]
            {
                new Movie("The Shawshank Redemption", "Frank Darabont", 1994, "Drama", 9.3),
                new Movie("Inception", "Christopher Nolan", 2010, "Sci-Fi", 8.8),
                new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0),
                new Movie("Pulp Fiction", "Quentin Tarantino", 1994, "Crime", 8.9),
                new Movie("Forrest Gump", "Robert Zemeckis", 1994, "Drama", 8.8),
                new Movie("The Matrix", "The Wachowskis", 1999, "Sci-Fi", 8.7)
            };

            // Populate ComboBox programmatically
            cboMovies.Items.Add("-- Select a Movie --");
            foreach (Movie movie in _movies)
            {
                cboMovies.Items.Add(movie.Title);
            }

            // Set default selection to the placeholder
            cboMovies.SelectedIndex = 0;
        }

        private void cboMovies_SelectedIndexChanged(object sender, EventArgs e)

        {

            System.Diagnostics.Debug.WriteLine(cboMovies.SelectedIndex);
            // Index 0 is the placeholder "-- Select a Movie --"
            if (cboMovies.SelectedIndex <= 0)
            {
                // Clear all detail labels
                lblTitleValue.Text = "";
                lblDirectorValue.Text = "";
                lblYearValue.Text = "";
                lblGenreValue.Text = "";
                lblRatingValue.Text = "";
            }
            else
            {
                // Subtract 1 because index 0 in ComboBox is the placeholder
                Movie selectedMovie = _movies[cboMovies.SelectedIndex - 1];

                // Display movie details
                lblTitleValue.Text = selectedMovie.Title;
                lblDirectorValue.Text = selectedMovie.Director;
                lblYearValue.Text = selectedMovie.ReleaseYear.ToString();
                lblGenreValue.Text = selectedMovie.Genre;
                lblRatingValue.Text = $"{selectedMovie.Rating}/10";
            }
        }
    }
}

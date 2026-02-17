using System;
using System.Windows.Forms;

namespace Demo4_MovieDatabase
{
    public partial class Form1 : Form
    {
        // Array of movies
        private Movie[] movies = new Movie[20];
        private int movieCount = 0;

        public Form1()
        {
            InitializeComponent();
            LoadSampleMovies();
        }

        // Pre-load 5 movies
        private void LoadSampleMovies()
        {
            movies[0] = new Movie("The Dark Knight", "Christopher Nolan", 2008, 9.0);
            movies[1] = new Movie("Inception", "Christopher Nolan", 2010, 8.8);
            movies[2] = new Movie("Pulp Fiction", "Quentin Tarantino", 1994, 8.9);
            movies[3] = new Movie("The Matrix", "Wachowski Sisters", 1999, 8.7);
            movies[4] = new Movie("Forrest Gump", "Robert Zemeckis", 1994, 8.8);
            movieCount = 5;
        }

        // Search for movie by title or director (case insensitive)
        // Returns index of movie or -1 if not found
        private int SearchMovie(string searchTerm)
        {
            string term = searchTerm.ToLower();
            
            for (int i = 0; i < movieCount; i++)
            {
                // Check if title contains search term
                if (movies[i].Title.ToLower().Contains(term))
                {
                    return i;
                }
                // Check if director contains search term
                if (movies[i].Director.ToLower().Contains(term))
                {
                    return i;
                }
            }
            return -1;
        }

        // Display movie info by index
        // If index is invalid (-1), shows error message
        private void ShowMovieInfo(int index)
        {
            if (index < 0 || index >= movieCount)
            {
                lblResult.Text = "Movie not found.\n\n" +
                                "Try searching by:\n" +
                                "- Movie title\n" +
                                "- Director name";
            }
            else
            {
                lblResult.Text = "Movie Found!\n\n" + movies[index].GetInfo();
            }
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                lblResult.Text = "Please enter a search term";
                return;
            }

            int index = SearchMovie(txtSearch.Text.Trim());
            ShowMovieInfo(index);
        }

        // Show all movies button click
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string allMovies = "All Movies in Database:\n";
            allMovies += "========================\n\n";

            for (int i = 0; i < movieCount; i++)
            {
                allMovies += $"{i + 1}. {movies[i].Title} ({movies[i].Year})\n";
                allMovies += $"   Dir: {movies[i].Director}\n";
                allMovies += $"   Rating: {movies[i].Rating:F1}\n\n";
            }

            lblResult.Text = allMovies;
        }
    }
}

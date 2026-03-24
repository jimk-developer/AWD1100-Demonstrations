namespace Demo1_MovieLibrary
{
    public class Movie
    {
        // Fields
        private string _title;
        private string _director;
        private int _releaseYear;
        private string _genre;
        private double _rating;

        // Constructor
        public Movie(string title, string director, int releaseYear, string genre, double rating)
        {
            _title = title;
            _director = director;
            _releaseYear = releaseYear;
            _genre = genre;
            _rating = rating;
        }

        // Properties
        public string Title
        {
            get { return _title; }
        }

        public string Director
        {
            get { return _director; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
        }

        public string Genre
        {
            get { return _genre; }
        }

        public double Rating
        {
            get { return _rating; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{_title} ({_releaseYear}) - Directed by {_director} | Genre: {_genre} | Rating: {_rating}/10";
        }
    }
}

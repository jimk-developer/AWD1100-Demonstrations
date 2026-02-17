using System;

namespace Demo4_MovieDatabase
{
    public class Movie
    {
        // Private fields
        private string _title;
        private string _director;
        private int _year;
        private double _rating;

        // Constructor
        public Movie(string title, string director, int year, double rating)
        {
            _title = title;
            _director = director;
            _year = year;
            _rating = rating;
        }

        // Read-only properties
        public string Title
        {
            get { return _title; }
        }

        public string Director
        {
            get { return _director; }
        }

        public int Year
        {
            get { return _year; }
        }

        public double Rating
        {
            get { return _rating; }
        }

        // GetInfo method returns formatted string
        public string GetInfo()
        {
            return $"{_title} ({_year})\n" +
                   $"Director: {_director}\n" +
                   $"Rating: {_rating:F1}/10";
        }
    }
}

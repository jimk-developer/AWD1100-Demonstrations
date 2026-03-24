namespace Demo5_PlaylistManager
{
    public class Song
    {
        // Fields
        private string _title;
        private string _artist;
        private double _durationMinutes;

        // Constructor
        public Song(string title, string artist, double durationMinutes)
        {
            _title = title;
            _artist = artist;
            _durationMinutes = durationMinutes;
        }

        // Properties
        public string Title
        {
            get { return _title; }
        }

        public string Artist
        {
            get { return _artist; }
        }

        public double DurationMinutes
        {
            get { return _durationMinutes; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{_title} - {_artist} ({_durationMinutes:F1} min)";
        }
    }
}

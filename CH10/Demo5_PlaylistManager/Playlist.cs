using System.Collections.Generic;

namespace Demo5_PlaylistManager
{
    public class Playlist
    {
        // Fields
        private string _name;
        private List<Song> _songs;

        // Constructor
        public Playlist(string name)
        {
            _name = name;
            _songs = new List<Song>();
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public List<Song> Songs
        {
            get { return _songs; }
        }

        // Methods
        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public bool RemoveSong(string title)
        {
            for (int i = 0; i < _songs.Count; i++)
            {
                if (_songs[i].Title == title)
                {
                    _songs.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // Override ToString
        public override string ToString()
        {
            string result = $"Playlist: {_name} ({_songs.Count} songs)\n";
            result += new string('-', 40) + "\n";
            for (int i = 0; i < _songs.Count; i++)
            {
                result += $"  {i + 1}. {_songs[i].ToString()}\n";
            }
            return result;
        }
    }
}

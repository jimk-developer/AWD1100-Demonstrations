namespace Demo7_TeamRoster
{
    public class Player
    {
        // Fields
        private string _name;
        private string _position;
        private int _jerseyNumber;

        // Constructor
        public Player(string name, string position, int jerseyNumber)
        {
            _name = name;
            _position = position;
            _jerseyNumber = jerseyNumber;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public string Position
        {
            get { return _position; }
        }

        public int JerseyNumber
        {
            get { return _jerseyNumber; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"#{_jerseyNumber} {_name} ({_position})";
        }
    }
}

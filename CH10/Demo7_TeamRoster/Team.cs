using System.Collections.Generic;

namespace Demo7_TeamRoster
{
    public class Team
    {
        // Fields
        private string _teamName;
        private List<Player> _players;

        // Constructor
        public Team(string teamName)
        {
            _teamName = teamName;
            _players = new List<Player>();
        }

        // Properties
        public string TeamName
        {
            get { return _teamName; }
        }

        public List<Player> Players
        {
            get { return _players; }
        }

        // Methods
        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public bool RemovePlayer(string playerName)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Name == playerName)
                {
                    _players.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        // Override ToString
        public override string ToString()
        {
            return _teamName;
        }
    }
}

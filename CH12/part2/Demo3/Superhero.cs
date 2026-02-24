using System;

namespace Demo3_Superheroes
{
    /// <summary>
    /// Represents a superhero with their abilities.
    /// Similar to a game character database lookup.
    /// </summary>
    public class Superhero
    {
        // Private fields
        private string _name;
        private HeroType _type;
        private string _primaryPower;
        private string _secondaryPower;
        private string _defensiveAbility;
        private string _mobilityAbility;
        private string _ultimateAbility;

        // Constructor
        public Superhero(string name, HeroType type, string primary, string secondary, 
                        string defensive, string mobility, string ultimate)
        {
            _name = name;
            _type = type;
            _primaryPower = primary;
            _secondaryPower = secondary;
            _defensiveAbility = defensive;
            _mobilityAbility = mobility;
            _ultimateAbility = ultimate;
        }

        // Read-only properties
        public string Name
        {
            get { return _name; }
        }

        public HeroType Type
        {
            get { return _type; }
        }

        public string PrimaryPower
        {
            get { return _primaryPower; }
        }

        public string SecondaryPower
        {
            get { return _secondaryPower; }
        }

        public string DefensiveAbility
        {
            get { return _defensiveAbility; }
        }

        public string MobilityAbility
        {
            get { return _mobilityAbility; }
        }

        public string UltimateAbility
        {
            get { return _ultimateAbility; }
        }

        /// <summary>
        /// Returns a formatted string with all hero information
        /// </summary>
        public string Display()
        {
            string output = $"═══════════════════════════════════\n";
            output += $"  {_name.ToUpper()}\n";
            output += $"  Type: {_type}\n";
            output += $"═══════════════════════════════════\n\n";
            output += $"  Primary Power:    {_primaryPower}\n";
            output += $"  Secondary Power:  {_secondaryPower}\n";
            output += $"  Defensive:        {_defensiveAbility}\n";
            output += $"  Mobility:         {_mobilityAbility}\n";
            output += $"  Ultimate:         {_ultimateAbility}\n";
            return output;
        }
    }
}

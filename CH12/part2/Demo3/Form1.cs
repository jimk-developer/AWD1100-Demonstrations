using Demo3_Superheroes;

namespace Demo3
{
    public partial class Form1 : Form
    {
        // Array of superheroes
        private Superhero[] heroes;
        private int heroCount = 0;

        public Form1()
        {
            InitializeComponent();
            LoadHeroes();
            LoadOptions();
        }
        // Load ComboBox with HeroType enum values
        private void LoadOptions()
        {
            // Load HeroType enum into ComboBox
            cmbType.DataSource = Enum.GetValues(typeof(HeroType));
        }

        // Pre-load superhero database
        private void LoadHeroes()
        {
            heroes = new Superhero[10];

            // Strength type heroes
            heroes[0] = new Superhero(
                "Titan",
                HeroType.Strength,
                "Mega Punch",
                "Ground Slam",
                "Stone Skin",
                "Leap",
                "Earthquake"
            );

            heroes[1] = new Superhero(
                "Colossus",
                HeroType.Strength,
                "Steel Fist",
                "Shockwave",
                "Metal Form",
                "Charge",
                "Meteor Strike"
            );

            // Speed type heroes
            heroes[2] = new Superhero(
                "Velocity",
                HeroType.Speed,
                "Rapid Strike",
                "Whirlwind",
                "Phase Shift",
                "Dash",
                "Time Freeze"
            );

            heroes[3] = new Superhero(
                "Quickstep",
                HeroType.Speed,
                "Flurry",
                "Sonic Boom",
                "Blur",
                "Blink",
                "Speed Vortex"
            );

            // Magic type heroes
            heroes[4] = new Superhero(
                "Mystic",
                HeroType.Magic,
                "Arcane Bolt",
                "Hex Curse",
                "Magic Shield",
                "Teleport",
                "Dimension Rift"
            );

            heroes[5] = new Superhero(
                "Enchantress",
                HeroType.Magic,
                "Spell Blast",
                "Chain Lightning",
                "Barrier",
                "Levitate",
                "Elemental Storm"
            );

            // Tech type heroes
            heroes[6] = new Superhero(
                "Circuit",
                HeroType.Tech,
                "Laser Beam",
                "Missile Barrage",
                "Energy Shield",
                "Jet Boost",
                "EMP Pulse"
            );

            heroes[7] = new Superhero(
                "Gadget",
                HeroType.Tech,
                "Plasma Shot",
                "Drone Strike",
                "Hologram Decoy",
                "Grapple",
                "Orbital Strike"
            );

            // Psychic type heroes
            heroes[8] = new Superhero(
                "Mindwave",
                HeroType.Psychic,
                "Psychic Blast",
                "Confusion",
                "Mental Block",
                "Astral Walk",
                "Brain Melt"
            );

            heroes[9] = new Superhero(
                "Telepath",
                HeroType.Psychic,
                "Mind Spike",
                "Fear Pulse",
                "Thought Shield",
                "Mind Leap",
                "Domination"
            );

            heroCount = 10;
        }

        // Search for hero by name (case insensitive)
        private int FindHero(string name)
        {
            for (int i = 0; i < heroCount; i++)
            {
                if (heroes[i].Name.ToLower() == name.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                lblResult.Text = "Please enter a hero name to search.";
                return;
            }

            int index = FindHero(txtSearch.Text.Trim());

            if (index >= 0)
            {
                lblResult.Text = heroes[index].Display();
            }
            else
            {
                lblResult.Text = $"Hero '{txtSearch.Text}' not found.\n\n" +
                                "Available heroes:\n" +
                                GetHeroList();
            }
        }

        // Get list of all hero names
        private string GetHeroList()
        {
            string list = "";
            for (int i = 0; i < heroCount; i++)
            {
                list += $"  • {heroes[i].Name} ({heroes[i].Type})\n";
            }
            return list;
        }

        // Show All button click
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string output = "SUPERHERO DATABASE\n";
            output += "══════════════════════════════════════\n\n";

            for (int i = 0; i < heroCount; i++)
            {
                output += $"{heroes[i].Name,-12} | {heroes[i].Type,-8} | " +
                         $"Primary: {heroes[i].PrimaryPower}\n";
            }

            lblResult.Text = output;
        }

        // Filter by type button click
        private void btnFilterByType_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                lblResult.Text = "Please select a hero type.";
                return;
            }

            HeroType selectedType = (HeroType)cmbType.SelectedItem;

            string output = $"Heroes of Type: {selectedType}\n";
            output += "══════════════════════════════════════\n\n";

            int found = 0;
            for (int i = 0; i < heroCount; i++)
            {
                if (heroes[i].Type == selectedType)
                {
                    output += heroes[i].Display() + "\n";
                    found++;
                }
            }

            if (found == 0)
            {
                output += "No heroes found of this type.";
            }

            lblResult.Text = output;
        }
    }
}


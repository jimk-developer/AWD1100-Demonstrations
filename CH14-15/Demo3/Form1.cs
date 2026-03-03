using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        // Array of all possible animal names (you will add images to Resources)
        // Resource images should be named: eagle, deer, fox, owl, bear, wolf,
        // rabbit, hawk, turtle, dolphin
        private string[] animalNames = {
            "Eagle", "Deer", "Fox", "Owl", "Bear",
            "Wolf", "Rabbit", "Hawk", "Turtle", "Dolphin"
        };

        private double[] rarityValues = {
            7.5, 3.0, 5.0, 6.0, 8.0,
            9.0, 2.0, 6.5, 4.0, 8.5
        };

        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateSpotting();
        }

        private void btnSpotAgain_Click(object sender, EventArgs e)
        {
            GenerateSpotting();
        }

        private void GenerateSpotting()
        {
            // Create array of 4 spotted animals
            IAnimal[] spotted = new IAnimal[4];

            PictureBox[] pics = { pic1, pic2, pic3, pic4 };
            Label[] labels = { lbl1, lbl2, lbl3, lbl4 };

            // Build a shuffled list of unique indices (Fisher-Yates shuffle)
            // This guarantees no duplicate animals appear in the same display
            int[] indices = new int[animalNames.Length];
            for (int i = 0; i < indices.Length; i++) indices[i] = i;
            for (int i = indices.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                int temp = indices[i];
                indices[i] = indices[j];
                indices[j] = temp;
            }

            for (int i = 0; i < 4; i++)
            {
                int index = indices[i];   // guaranteed unique per display
                string name = animalNames[index];
                double rarity = rarityValues[index];

                // Get image from Resources
                // NOTE: You must add images to the project's Resources
                // Properties > Resources > Add Resource > Add Existing File
                // Name them: eagle, deer, fox, owl, bear, wolf, rabbit, hawk, turtle, dolphin
                Image img = GetAnimalImage(name);

                // 25% chance of being a rare sighting
                if (rng.Next(100) < 25)
                {
                    spotted[i] = new RareAnimal(
                        name,
                        img,
                        rarity * 2,  // rare animals have double rarity value
                        new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Italic),
                        Color.Gold,
                        Color.DarkRed
                    );
                }
                else
                {
                    spotted[i] = new CommonAnimal(name, img, rarity);
                }
            }

            // Sort by rarity using IComparable 
            Array.Sort(spotted);

            // Display each animal using polymorphism
            for (int i = 0; i < 4; i++)
            {
                spotted[i].ShowAnimal(pics[i], labels[i]);
            }
        }

        private Image GetAnimalImage(string name)
        {
            // This method retrieves images from the project's Resources.
            // In Visual Studio:
            //   1. Right-click project > Properties > Resources
            //   2. Add each animal image (eagle.png, deer.png, etc.)
            //   3. Access via Properties.Resources.eagle, etc.
            //
            // For this demo, use a switch to return the correct resource:
            //
            switch (name.ToLower())
            {
                case "eagle": return Properties.Resources.eagle;
                case "deer": return Properties.Resources.deer;
                case "fox": return Properties.Resources.fox;
                case "owl": return Properties.Resources.owl;
                case "bear": return Properties.Resources.bear;
                case "wolf": return Properties.Resources.wolf;
                case "rabbit": return Properties.Resources.rabbit;
                case "hawk": return Properties.Resources.hawk;
                case "turtle": return Properties.Resources.turtle;
                case "dolphin": return Properties.Resources.dolphin;
                default: return Properties.Resources.eagle;
            }
        }
    }
}

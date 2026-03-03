using System.Drawing;
using System.Windows.Forms;

namespace Demo3
{
    public class RareAnimal : IAnimal
    {
        // Private fields
        private string _name;
        private Image _image;
        private double _rarity;
        private Font _font;
        private Color _backColor;
        private Color _foreColor;

        // Constructor
        public RareAnimal(string name, Image image, double rarity,
                          Font font, Color backColor, Color foreColor)
        {
            _name = name;
            _image = image;
            _rarity = rarity;
            _font = font;
            _backColor = backColor;
            _foreColor = foreColor;
        }

        // ShowAnimal - displays with special styling
        public void ShowAnimal(PictureBox pictureBox, Label label)
        {
            pictureBox.Image = _image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = _backColor;

            label.Text = _name + " (Rare!)";
            label.Font = _font;
            label.ForeColor = _foreColor;
            label.BackColor = _backColor;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public Image AnimalImage
        {
            get { return _image; }
        }

        public double Rarity
        {
            get { return _rarity; }
        }

        // IComparable - sort by rarity (highest first)
        public int CompareTo(IAnimal other)
        {
            System.Diagnostics.Debug.WriteLine($"Comparing {this.Name} ({this.Rarity}) to {other.Name} ({other.Rarity})");

            return other.Rarity.CompareTo(this._rarity);
        }
    }
}

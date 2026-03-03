using System.Drawing;
using System.Windows.Forms;

namespace Demo3
{
    public class CommonAnimal : IAnimal
    {
        // Private fields
        private string _name;
        private Image _image;
        private double _rarity;

        // Constructor
        public CommonAnimal(string name, Image image, double rarity)
        {
            _name = name;
            _image = image;
            _rarity = rarity;
        }

        // ShowAnimal - displays normally
        public void ShowAnimal(PictureBox pictureBox, Label label)
        {
            pictureBox.Image = _image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.White;

            label.Text = _name;
            label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label.ForeColor = Color.Black;
            label.BackColor = Color.Transparent;
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

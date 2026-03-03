using System.Drawing;
using System.Windows.Forms;

namespace Demo3
{
    public interface IAnimal : System.IComparable<IAnimal>
    {
        // Method to display the animal in a PictureBox and Label
        void ShowAnimal(PictureBox pictureBox, Label label);

        // Properties
        string Name { get; }
        Image AnimalImage { get; }
        double Rarity { get; }
    }
}

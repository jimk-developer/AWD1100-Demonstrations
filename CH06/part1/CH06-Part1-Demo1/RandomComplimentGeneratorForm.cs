namespace CH06_Part1_Demo1
{
    public partial class RandomComplimentGeneratorForm : Form
    {
        // Array of compliments at class level
           private readonly string[] compliments = {
            "You have an amazing sense of humor!",
            "Your creativity inspires everyone around you.",
            "You make difficult things look easy.",
            "Your positive attitude is contagious.",
            "You are braver than you believe.",
            "Your kindness makes the world a better place.",
            "You have a wonderful way with words.",
            "Your hard work does not go unnoticed."
        };
        // Random number generator at class level
        Random rand = new Random();
        public RandomComplimentGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Call the method to generate compliments
            GenerateCompliments();
        }
        private void GenerateCompliments()
        {
            // Generate first random index
            int index1 = rand.Next(0, compliments.Length);

            // Generate second random index (must be different from first)
            int index2 = rand.Next(0, compliments.Length);

            // Make sure we get two different compliments
            while (index2 == index1)
            {
                index2 = rand.Next(0, compliments.Length);
            }

            // Display the compliments
            lblCompliment1.Text = compliments[index1];
            lblCompliment2.Text = compliments[index2];
        }
    }
}

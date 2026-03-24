using System;
using System.Windows.Forms;

namespace Demo2_RecipeFinder
{
    public partial class Form1 : Form
    {
        // Array of Category objects
        private Category[] _categories;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Recipe objects organized by category
            Recipe[] breakfastRecipes = new Recipe[]
            {
                new Recipe("Pancakes", "Breakfast", 20, "Easy", "Flour, Eggs, Milk, Butter, Syrup"),
                new Recipe("Veggie Omelette", "Breakfast", 15, "Easy", "Eggs, Bell Pepper, Onion, Cheese")
            };

            Recipe[] lunchRecipes = new Recipe[]
            {
                new Recipe("Grilled Cheese", "Lunch", 10, "Easy", "Bread, Cheddar, Butter"),
                new Recipe("Caesar Salad", "Lunch", 15, "Easy", "Romaine, Croutons, Parmesan, Dressing")
            };

            Recipe[] dinnerRecipes = new Recipe[]
            {
                new Recipe("Spaghetti Bolognese", "Dinner", 45, "Medium", "Pasta, Ground Beef, Tomato Sauce, Garlic, Onion"),
                new Recipe("Chicken Stir Fry", "Dinner", 30, "Medium", "Chicken Breast, Broccoli, Soy Sauce, Rice")
            };

            Recipe[] dessertRecipes = new Recipe[]
            {
                new Recipe("Chocolate Brownies", "Dessert", 40, "Easy", "Chocolate, Butter, Sugar, Eggs, Flour"),
                new Recipe("Fruit Parfait", "Dessert", 10, "Easy", "Yogurt, Granola, Mixed Berries, Honey")
            };

            Recipe[] snackRecipes = new Recipe[]
            {
                new Recipe("Guacamole", "Snack", 10, "Easy", "Avocado, Lime, Cilantro, Onion, Tomato"),
                new Recipe("Trail Mix", "Snack", 5, "Easy", "Peanuts, Almonds, Raisins, Chocolate Chips")
            };

            // Create Category objects
            _categories = new Category[]
            {
                new Category("Breakfast", breakfastRecipes),
                new Category("Lunch", lunchRecipes),
                new Category("Dinner", dinnerRecipes),
                new Category("Dessert", dessertRecipes),
                new Category("Snack", snackRecipes)
            };

            // Populate ListBox programmatically
            foreach (Category category in _categories)
            {
                lstCategories.Items.Add(category.Name);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if at least one category is selected
            if (lstCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one category.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build results string from selected categories
            string results = "";

            foreach (string selectedName in lstCategories.SelectedItems)
            {
                // Find matching category
                foreach (Category category in _categories)
                {
                    if (category.Name == selectedName)
                    {
                        results += $"=== {category.Name} ===\n";
                        foreach (Recipe recipe in category.Recipes)
                        {
                            results += $"  {recipe.ToString()}\n\n";
                        }
                    }
                }
            }

            // Show results in a modal window
            ResultsForm resultsForm = new ResultsForm(results);
            resultsForm.ShowDialog();
        }
    }
}

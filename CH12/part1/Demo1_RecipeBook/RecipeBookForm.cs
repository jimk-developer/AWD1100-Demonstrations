using System;
using System.Windows.Forms;

namespace Demo1_RecipeBook
{
    public partial class RecipeBookForm : Form
    {
        // Array to store recipes and counter
        private Recipe[] recipes = new Recipe[15];
        private int recipeCount = 0;

        public RecipeBookForm()
        {
            InitializeComponent();
            LoadSampleRecipes();
        }

        // Pre-load 3 sample recipes
        private void LoadSampleRecipes()
        {
            recipes[0] = new Recipe(
                "Pancakes",
                "2 cups flour\n1 egg\n1 cup milk\n2 tbsp sugar\n1 tsp baking powder",
                "1. Mix dry ingredients\n2. Add egg and milk\n3. Cook on griddle until golden"
            );
            recipes[1] = new Recipe(
                "Grilled Cheese",
                "2 slices bread\n2 slices cheese\n1 tbsp butter",
                "1. Butter outside of bread\n2. Place cheese between slices\n3. Grill until golden and cheese melts"
            );
            recipes[2] = new Recipe(
                "Scrambled Eggs",
                "3 eggs\n2 tbsp milk\nSalt and pepper\n1 tbsp butter",
                "1. Beat eggs with milk\n2. Melt butter in pan\n3. Cook eggs, stirring gently"
            );
            recipeCount = 3;
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtRecipeName.Text))
            {
                lblResult.Text = "Please enter a recipe name";
                return;
            }

            string searchName = txtRecipeName.Text.Trim();

            // Search for recipe (case insensitive)
            int index = FindRecipe(searchName);

            if (index >= 0)
            {
                // Recipe found - display it
                lblResult.Text = recipes[index].Display();

                // Hide add section
                lblIngredientsPrompt.Visible = false;
                txtIngredients.Visible = false;
                lblInstructionsPrompt.Visible = false;
                txtInstructions.Visible = false;
                btnAdd.Visible = false;
            }
            else
            {
                // Recipe not found - show add section
                lblResult.Text = $"Recipe '{searchName}' not found. Add it below!";

                // Show add section
                lblIngredientsPrompt.Visible = true;
                txtIngredients.Visible = true;
                lblInstructionsPrompt.Visible = true;
                txtInstructions.Visible = true;
                btnAdd.Visible = true;

                // Clear add fields
                txtIngredients.Clear();
                txtInstructions.Clear();
                txtIngredients.Focus();
            }
        }

        // Find recipe by name (case insensitive)
        private int FindRecipe(string name)
        {
            for (int i = 0; i < recipeCount; i++)
            {
                if (recipes[i].Name.ToLower() == name.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        // Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtRecipeName.Text))
            {
                lblResult.Text = "Please enter a recipe name";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIngredients.Text))
            {
                lblResult.Text = "Please enter ingredients";
                return;
            }
            if (string.IsNullOrWhiteSpace(txtInstructions.Text))
            {
                lblResult.Text = "Please enter instructions";
                return;
            }

            // Check if array is full
            if (recipeCount >= recipes.Length)
            {
                lblResult.Text = "Recipe book is full! Maximum 15 recipes.";
                return;
            }

            // Check if recipe already exists
            if (FindRecipe(txtRecipeName.Text.Trim()) >= 0)
            {
                lblResult.Text = "This recipe already exists!";
                return;
            }

            // Create new recipe and add to array
            Recipe newRecipe = new Recipe(
                txtRecipeName.Text.Trim(),
                txtIngredients.Text.Trim(),
                txtInstructions.Text.Trim()
            );

            recipes[recipeCount] = newRecipe;
            recipeCount++;

            // Display success message
            lblResult.Text = $"'{newRecipe.Name}' added successfully!\n\n" + newRecipe.Display();

            // Hide add section and clear fields
            lblIngredientsPrompt.Visible = false;
            txtIngredients.Visible = false;
            lblInstructionsPrompt.Visible = false;
            txtInstructions.Visible = false;
            btnAdd.Visible = false;

            txtRecipeName.Clear();
            txtIngredients.Clear();
            txtInstructions.Clear();
            txtRecipeName.Focus();
        }
    }
}

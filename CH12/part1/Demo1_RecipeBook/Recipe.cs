using System;

namespace Demo1_RecipeBook
{
    public class Recipe
    {
        // Private fields
        private string _name;
        private string _ingredients;
        private string _instructions;

        // Constructor
        public Recipe(string name, string ingredients, string instructions)
        {
            _name = name;
            _ingredients = ingredients;
            _instructions = instructions;
        }

        // Read-only properties
        public string Name
        {
            get { return _name; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
        }

        public string Instructions
        {
            get { return _instructions; }
        }

        // Display method returns formatted string
        public string Display()
        {
            return $"Recipe: {_name}\n\n" +
                   $"Ingredients:\n{_ingredients}\n\n" +
                   $"Instructions:\n{_instructions}";
        }
    }
}

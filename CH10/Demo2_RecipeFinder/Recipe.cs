namespace Demo2_RecipeFinder
{
    public class Recipe
    {
        // Fields
        private string _name;
        private string _category;
        private int _prepTimeMinutes;
        private string _difficulty;
        private string _ingredients;

        // Constructor
        public Recipe(string name, string category, int prepTimeMinutes, string difficulty, string ingredients)
        {
            _name = name;
            _category = category;
            _prepTimeMinutes = prepTimeMinutes;
            _difficulty = difficulty;
            _ingredients = ingredients;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public string Category
        {
            get { return _category; }
        }

        public int PrepTimeMinutes
        {
            get { return _prepTimeMinutes; }
        }

        public string Difficulty
        {
            get { return _difficulty; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{_name} ({_category}) - {_prepTimeMinutes} min | {_difficulty}\nIngredients: {_ingredients}";
        }
    }
}

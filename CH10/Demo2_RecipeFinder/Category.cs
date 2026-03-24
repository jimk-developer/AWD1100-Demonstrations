namespace Demo2_RecipeFinder
{
    public class Category
    {
        // Fields
        private string _name;
        private Recipe[] _recipes;

        // Constructor
        public Category(string name, Recipe[] recipes)
        {
            _name = name;
            _recipes = recipes;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public Recipe[] Recipes
        {
            get { return _recipes; }
        }

        // Override ToString
        public override string ToString()
        {
            return _name;
        }
    }
}

using System;

namespace Demo1
{
    /// <summary>
    /// Represents a pastry item in the coffee shop order.
    /// This class is used as part of the CoffeeOrder (composition).
    /// </summary>
    public class Pastry
    {
        // Private fields
        private string _name;
        private decimal _price;
        private bool _warmed;

        // Constructor
        public Pastry(string name, decimal price, bool warmed = false)
        {
            _name = name;
            _price = price;
            _warmed = warmed;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public decimal Price
        {
            get { return _price; }
        }

        public bool Warmed
        {
            get { return _warmed; }
            set { _warmed = value; }
        }

        // Display method
        public string Display()
        {
            string warmedText = _warmed ? " (warmed)" : "";
            return $"{_name}{warmedText}: {_price:C}";
        }
    }
}

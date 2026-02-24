using System;

namespace Demo1
{
    /// <summary>
    /// Represents a drink in the coffee shop order.
    /// This class is used as part of the CoffeeOrder (composition).
    /// </summary>
    public class Drink
    {
        // Private fields
        private DrinkType _type;
        private DrinkSize _size;
        private decimal _price;

        // Constructor
        public Drink(DrinkType type, DrinkSize size)
        {
            _type = type;
            _size = size;
            _price = CalculatePrice();
        }
        

        // Calculate price based on size
        private decimal CalculatePrice()
        {
            switch (_size)
            {
                case DrinkSize.Small:
                    return 2.50m;
                case DrinkSize.Medium:
                    return 3.25m;
                case DrinkSize.Large:
                    return 4.00m;
                default:
                    return 0m;
            }
        }

        // Properties
        public DrinkType Type
        {
            get { return _type; }
        }

        public DrinkSize Size
        {
            get { return _size; }
        }

        public decimal Price
        {
            get { return _price; }
        }

        // Display method
        public string Display()
        {
            return $"{_size} {_type}: {_price:C}";
        }
    }
}

using System;

namespace Demo1
{
    /// <summary>
    /// Represents a complete coffee shop order.
    /// DEMONSTRATES COMPOSITION: A CoffeeOrder HAS-A Drink and HAS-A Pastry.
    /// The Drink and Pastry objects are "part of" the CoffeeOrder.
    /// </summary>
    public class CoffeeOrder
    {
        // Composition: CoffeeOrder contains Drink and Pastry objects
        private Drink _drink;       // HAS-A Drink (composition)
        private Pastry _pastry;     // HAS-A Pastry (composition)
        private string _customerName;
        private decimal _totalPrice;

        // Tax rate constant
        private const decimal TAX_RATE = 0.08m;

        // Constructor with drink only
        public CoffeeOrder(string customerName, Drink drink)
        {
            _customerName = customerName;
            _drink = drink;
            _pastry = null;
            CalculateTotal();
        }

        // Constructor with drink and pastry
        public CoffeeOrder(string customerName, Drink drink, Pastry pastry)
        {
            _customerName = customerName;
            _drink = drink;
            _pastry = pastry;
            CalculateTotal();
        }

        // Calculate total including tax
        private void CalculateTotal()
        {
            decimal subtotal = 0;

            if (_drink != null)
            {
                subtotal += _drink.Price;
            }

            if (_pastry != null)
            {
                subtotal += _pastry.Price;
            }

            _totalPrice = subtotal + (subtotal * TAX_RATE);
        }

        // Properties
        public string CustomerName
        {
            get { return _customerName; }
        }

        public Drink Drink
        {
            get { return _drink; }
        }

        public Pastry Pastry
        {
            get { return _pastry; }
        }

        public decimal TotalPrice
        {
            get { return _totalPrice; }
        }

        // Get subtotal (before tax)
        public decimal GetSubtotal()
        {
            decimal subtotal = 0;
            if (_drink != null) subtotal += _drink.Price;
            if (_pastry != null) subtotal += _pastry.Price;
            return subtotal;
        }

        // Get tax amount
        public decimal GetTax()
        {
            return GetSubtotal() * TAX_RATE;
        }

        // Display the complete order
        public string Display()
        {
            string output = $"Order for: {_customerName}\n";
            output += "─────────────────────\n";

            if (_drink != null)
            {
                output += $"  {_drink.Display()}\n";
            }

            if (_pastry != null)
            {
                output += $"  {_pastry.Display()}\n";
            }

            output += "─────────────────────\n";
            output += $"Subtotal: {GetSubtotal():C}\n";
            output += $"Tax (8%): {GetTax():C}\n";
            output += $"TOTAL: {_totalPrice:C}";

            return output;
        }
    }
}

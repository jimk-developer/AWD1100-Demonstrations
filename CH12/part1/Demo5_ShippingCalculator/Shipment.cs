using System;

namespace Demo5_ShippingCalculator
{
    public class Shipment
    {
        // Private fields
        private string _description;
        private double _weight;
        private decimal _ratePerPound;
        private decimal _totalCost;

        // Constant for handling fee
        private const decimal HANDLING_FEE = 4.50m;

        // Constructor
        public Shipment(string description, double weight, decimal ratePerPound)
        {
            _description = description;
            _weight = weight;
            _ratePerPound = ratePerPound;
            CalculateTotalCost();
        }

        // Private method to calculate total cost
        private void CalculateTotalCost()
        {
            decimal baseCost = (decimal)_weight * _ratePerPound;
            _totalCost = baseCost + HANDLING_FEE;
        }

        // Properties
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set 
            { 
                _weight = value;
                CalculateTotalCost();  // Recalculate when weight changes
            }
        }

        public decimal RatePerPound
        {
            get { return _ratePerPound; }
            set 
            { 
                _ratePerPound = value;
                CalculateTotalCost();  // Recalculate when rate changes
            }
        }

        // Read-only property for total cost
        public decimal TotalCost
        {
            get { return _totalCost; }
        }
    }
}

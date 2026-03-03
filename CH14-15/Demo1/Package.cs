using System;

namespace Demo1
{
    public class Package
    {
        // Protected fields
        protected string _recipient;
        protected DateTime _shipDate;
        protected double _weight;

        // Constructor
        public Package(string recipient, DateTime shipDate, double weight)
        {
            _recipient = recipient;
            _shipDate = shipDate;
            _weight = weight;
        }

        // Properties
        public string Recipient
        {
            get { return _recipient; }
        }

        public DateTime ShipDate
        {
            get { return _shipDate; }
        }

        public double Weight
        {
            get { return _weight; }
        }

        // Virtual property - can be overridden by subclasses
        public virtual double Cost
        {
            get { return _weight * 1.50; }  // $1.50 per pound
        }

        // Override ToString
        public override string ToString()
        {
            return $"{ShipDate:dMMMyyyy}, {Recipient}, {Weight}lb, {Cost:C}";
        }
    }
}

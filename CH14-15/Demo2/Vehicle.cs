using System;

namespace Demo2
{
    public class Vehicle
    {
        // Protected fields
        protected string _make;
        protected string _model;
        protected int _year;

        // Constructor
        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        // Properties
        public string Make
        {
            get { return _make; }
        }

        public string Model
        {
            get { return _model; }
        }

        public int Year
        {
            get { return _year; }
        }

        // Virtual property for daily rental rate
        public virtual double DailyRate
        {
            get { return 45.00; }  // Base rate: $45/day
        }

        // Override ToString
        public override string ToString()
        {
            return $"{Year} {Make} {Model} - {DailyRate:C}/day";
        }
    }
}

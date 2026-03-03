using System;

namespace Demo2
{
    public class ElectricVehicle : Vehicle
    {
        // Additional field
        private FuelType _fuelType;

        // Constructor
        public ElectricVehicle(string make, string model, int year, FuelType fuelType)
            : base(make, model, year)
        {
            _fuelType = fuelType;
        }

        // Property
        public FuelType FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        // Override DailyRate - adds $20 for eco vehicles
        public override double DailyRate
        {
            get { return base.DailyRate + 20.00; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{Year} {Make} {Model} ({FuelType}) - {DailyRate:C}/day";
        }
    }
}

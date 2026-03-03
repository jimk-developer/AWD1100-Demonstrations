using System;

namespace Demo2
{
    public class LuxuryVehicle : Vehicle
    {
        // Additional fields
        private TrimLevel _trimLevel;
        private DriveType _driveType;

        // Constructor
        public LuxuryVehicle(string make, string model, int year, TrimLevel trimLevel, DriveType driveType)
            : base(make, model, year)
        {
            _trimLevel = trimLevel;
            _driveType = driveType;
        }

        // Properties
        public TrimLevel TrimLevel
        {
            get { return _trimLevel; }
            set { _trimLevel = value; }
        }

        public DriveType DriveType
        {
            get { return _driveType; }
            set { _driveType = value; }
        }

        // Override DailyRate - adds $50 for luxury
        public override double DailyRate
        {
            get { return base.DailyRate + 50.00; }
        }

        // Override ToString
        public override string ToString()
        {
            return $"{Year} {Make} {Model} ({TrimLevel}, {DriveType}) - {DailyRate:C}/day";
        }
    }
}

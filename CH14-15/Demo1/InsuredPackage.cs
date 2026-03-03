using System;

namespace Demo1
{
    public class InsuredPackage : Package
    {
        // Additional field for insurance
        private string _policyNumber;

        // Constructor - calls base constructor
        public InsuredPackage(string recipient, DateTime shipDate, double weight, string policyNumber)
            : base(recipient, shipDate, weight)
        {
            _policyNumber = policyNumber;
        }

        // Property
        public string PolicyNumber
        {
            get { return _policyNumber; }
        }

        // Override Cost - adds $5.00 insurance fee
        public override double Cost
        {
            get { return base.Cost + 5.00; }
        }

        // Override ToString - includes policy number
        public override string ToString()
        {
            return $"{ShipDate:dMMMyyyy}, {Recipient}, {Weight}lb, {Cost:C}, Policy#{PolicyNumber}";
        }
    }
}

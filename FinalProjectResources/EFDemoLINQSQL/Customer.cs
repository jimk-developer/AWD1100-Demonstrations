using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQSQL
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public double Budget { get; set; } = 0;
        public string Address { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{CustomerName} has a budget of {Budget:C}.\n";
        }
    }
}

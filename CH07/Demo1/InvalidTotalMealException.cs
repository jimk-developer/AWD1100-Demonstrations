using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    internal class InvalidTotalMealException : ArgumentException
    {
        public InvalidTotalMealException(string message) : base(message)
        {

        }
    }
}

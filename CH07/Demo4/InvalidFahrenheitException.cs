using System;
using System.Collections.Generic;
using System.Text;

namespace Demo4
{
    internal class InvalidFahrenheitException : ArgumentException
    {
        public InvalidFahrenheitException(string message) : base(message) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Demo4
{
    internal class InvalidCelsiusException : ArgumentException
    {
        public InvalidCelsiusException(string message) : base(message) { }
    }
}

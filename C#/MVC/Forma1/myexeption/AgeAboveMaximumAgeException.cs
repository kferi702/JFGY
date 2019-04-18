using System;

namespace Forma1.myexeption
{
    public class AgeAboveMaximumAgeException : Exception
    {
        public AgeAboveMaximumAgeException(string message) : base(message)
        { }
    }
}

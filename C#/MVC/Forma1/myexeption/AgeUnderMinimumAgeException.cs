using System;

namespace Forma1.myexeption
{
    public class AgeUnderMinimumAgeException : Exception
    {
        public AgeUnderMinimumAgeException(string message) : base(message)
        { }
    }
}

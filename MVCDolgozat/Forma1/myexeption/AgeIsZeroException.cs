using System;

namespace Forma1.myexeption
{
    public class AgeIsZeroException : Exception
    {
        public AgeIsZeroException(string message) : base(message)
        { }
    }
}

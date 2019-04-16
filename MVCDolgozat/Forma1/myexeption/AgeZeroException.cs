using System;

namespace Forma1.myexeption
{
    public class AgeZeroException : Exception
    {
        public AgeZeroException(string message) : base(message)
        { }
    }
}

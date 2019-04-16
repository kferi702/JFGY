using System;

namespace Forma1.myexeption
{
    public class SalaryZeroException : Exception
    {
        public SalaryZeroException() : base("Fizetés nem lehet nulla!")
        { }
    }
}

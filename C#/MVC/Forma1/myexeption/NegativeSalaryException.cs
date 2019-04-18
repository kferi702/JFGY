using System;

namespace Forma1.myexeption
{
    public class NegativeSalaryException : Exception
    {
        public NegativeSalaryException() : base("Fizetés nem lehet negatív!")
        { }
    }
}

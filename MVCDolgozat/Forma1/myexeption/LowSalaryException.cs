using System;

namespace Forma1.myexeption
{
    public class LowSalaryException : Exception
    {
        public LowSalaryException() : base("Alacsony fiztés!")
        { }
    }
}

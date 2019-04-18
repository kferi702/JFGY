using System;

namespace Forma1.myexeption
{
    public class HighSalaryException : Exception
    {
        public HighSalaryException() : base("Túl magas fizetés!")
        { }
    }
}

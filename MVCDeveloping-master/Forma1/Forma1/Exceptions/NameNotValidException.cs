using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.MyExceptions
{
    public class NameNotValidException : Exception
    {
        public NameNotValidException(string message) : base(message)
        {
        }
    }
}

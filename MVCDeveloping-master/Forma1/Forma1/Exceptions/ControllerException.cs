using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Exceptions
{
    public class ControllerException : Exception
    {
        public ControllerException(string message) : base(message)
        {
        }
    }
}

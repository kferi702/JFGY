using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.MyException
{
    public class TeamException : Exception
    {
        public TeamException(string message) : base(message)
        { }
    }
}

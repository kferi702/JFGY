using System;

namespace Forma1.Controller
{
    public class ControllerException : Exception
    {
        public ControllerException(string message) : base(message)
        {
        }
    }
}

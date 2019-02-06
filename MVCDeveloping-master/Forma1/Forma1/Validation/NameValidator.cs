using System;
using Forma1.MyExceptions;

namespace Forma1.Validation
{
    public class NameValidator
    {
        private string name;

        public NameValidator(string name)
        {
            this.name = name;
        }

        public void validation()
        {
            if (isEmpty())
            {
                throw new NameNotValidException("A név nem lehet üres!");
            }

            if (isFirstLetterNotUppercase())
            {
                throw new NameNotValidException("A név nagy kezdőbetűvel kell kezdődjön!");
            }
        }

        private bool isFirstLetterNotUppercase()
        {
            if (name.Length == 0)
            {
                return true;
            }

            if (char.IsLower(name[0]))
            {
                return true;
            }

            return false;
        }

        private bool isEmpty()
        {
            if (name == string.Empty)
            {
                return true;
            }

            return false;
        }
    }
}

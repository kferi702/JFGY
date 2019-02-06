using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("A név nem lehet üres!");
            }

            if (isFirstLetterNotUppercase())
            {
                throw new Exception("A név nagy kezdőbetűvel kell kezdődjön!");
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

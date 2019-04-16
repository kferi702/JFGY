using System;
using Forma1.myexeption;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation
{
    public class AgeValidator
    {
        private readonly int age;
        private readonly int minAge;
        private readonly int maxAge;

        public AgeValidator(int age)
        {
            this.age = age;

            minAge = 18;
            maxAge = 50;
        }

        public void validation()
        {
            if (isZero())
            {
                throw new AgeIsZeroException("Életkor nem lehet nulla!");
            }
            if (isUnderMinAge())
            {
                throw new AgeUnderMinimumAgeException("Életkor a minimum életkor alatt van!");
            }
            if (isAboveMaxAge())
            {
                throw new AgeAboveMaximumAgeException("Életkor a maximum életkor felett van!");
            }
        }

        private bool isAboveMaxAge()
        {
            return age > maxAge ? true : false;
        }

        private bool isUnderMinAge()
        {
            return age < minAge ? true : false;
        }

        private bool isZero()
        {
            return age == 0 ? true : false;
        }
    }
}

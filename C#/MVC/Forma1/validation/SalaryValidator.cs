﻿using System;
using Forma1.myexeption;

namespace Forma1.validation
{
    public class SalaryValidator
    {
        private readonly int salary;
        private readonly int maxSalary;

        public SalaryValidator(int salary)
        {
            this.salary = salary;
            maxSalary = 1000000;
        }

        public void validation()
        {
            if (SalaryIsZero())
            {
                throw new SalaryZeroException();
            }

            if (SalaryIsNegative())
            {
                throw new NegativeSalaryException();
            }

            if (SalaryIsAboveMax())
            {
                throw new HighSalaryException();
            }
        }

        private bool SalaryIsAboveMax()
        {
            return salary > maxSalary ? true : false;
        }

        private bool SalaryIsNegative()
        {
            return salary < 0 ? true : false;
        }

        private bool SalaryIsZero()
        {
            return salary == 0 ? true : false;
        }
    }
}

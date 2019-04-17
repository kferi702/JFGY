using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.myexeption;

namespace Forma1.validation.Tests
{
    [TestClass()]
    public class SalaryValidatorTests
    {
        [TestMethod()]
        public void validationTest_InCaseSalaryIsZero()
        {
            try
            {
                SalaryValidator salaryValidator = new SalaryValidator(0);
                salaryValidator.validation();
                Assert.Fail("Nem dob kivételt nulla fizetésre!");
            }
            catch (SalaryZeroException) { }
        }

        [TestMethod()]
        public void validationTest_InCaseSalaryIsNegtive()
        {
            try
            {
                SalaryValidator salaryValidator = new SalaryValidator(-1000);
                salaryValidator.validation();
                Assert.Fail("Nem dob kivételt negatív fizetésre!");
            }
            catch (NegativeSalaryException) { }
        }

        [TestMethod()]
        public void validationTest_InCaseSalaryIsHigh()
        {
            try
            {
                SalaryValidator salaryValidator = new SalaryValidator(2000000);
                salaryValidator.validation();
                Assert.Fail("Nem dob kivételt magas fizetésre!");
            }
            catch (HighSalaryException) { }
        }
    }
}

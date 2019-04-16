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
    public class AgeValidatorTests
    {
        [TestMethod()]
        public void validationTest_AgeIsZero()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(0);
                ageValidator.validation();
                Assert.Fail("Nem dob kivételt 0 életkorra!");
            }
            catch (AgeZeroException)
            {
            }
        }

        [TestMethod()]
        public void validationTest_AgeIsUnderMinAge()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(11);
                ageValidator.validation();
                Assert.Fail("Nem dob kivételt alacsony életkorra!");
            }
            catch (AgeUnderMinimumAgeException)
            {
            }
        }

        [TestMethod()]
        public void validationTest_AgeIsAboveMaxAge()
        {
            try
            {
                AgeValidator ageValidator = new AgeValidator(55);
                ageValidator.validation();
                Assert.Fail("Nem dob kivételt magas életkorra!");
            }
            catch (AgeAboveMaximumAgeException)
            {
            }
        }
    }
}

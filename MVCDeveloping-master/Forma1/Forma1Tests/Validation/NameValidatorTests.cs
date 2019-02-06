using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Validation.Tests
{
    [TestClass()]
    public class NameValidatorTests
    {
        [TestMethod()]
        public void validationTestNameIsEmpty()
        {
            NameValidator nv = new NameValidator("");
            try
            {
                nv.validation();
                Assert.Fail("Üres névre nem dob kivételt!");
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void validationTestNameNotBeginsWithUppercase()
        {
            NameValidator nv = new NameValidator("nemecsek");
            try
            {
                nv.validation();
                Assert.Fail("Kisbetűvel kezdődő névre nem dob kivételt!");
            }
            catch (Exception e)
            {
            }
        }

        [TestMethod()]
        public void validationTestNameValid()
        {
            NameValidator nv = new NameValidator("Nemecsek");
            try
            {
                nv.validation();
            }
            catch (Exception e)
            {
            }
        }
    }
}

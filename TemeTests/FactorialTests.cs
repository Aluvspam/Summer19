using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme.Tests
{
    [TestClass()]
    public class FactorialTests
    {
        [TestMethod()]
        public void Factorial1Test()
        {
            var testObj = new Factorial();
            Assert.AreEqual(120, testObj.Factorial1(5));
            Assert.AreEqual(1, testObj.Factorial1(0));
        }
    }
}
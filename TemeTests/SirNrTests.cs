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
    public class SirNrTests
    {
        [TestMethod()]
        public void SirNrTest()

        {
            var testfib = new SirNr();
            Assert.AreEqual(10,testfib.Sirnr(4));
        }
    }
}
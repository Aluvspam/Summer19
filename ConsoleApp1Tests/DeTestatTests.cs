using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class DeTestatTests
    {
        DeTestat TestObj = new DeTestat();
        [TestMethod()]
        public void SumaTest()
        {
            Assert.AreEqual(47, TestObj.Suma(3, 44));
        }

        [TestMethod()]
        public void ProdusTest()
        {
            Assert.AreEqual(98, TestObj.Produs(7, 14));
        }
        [TestMethod()]
        public void Impart()
        {
            Assert.AreNotEqual(4, TestObj.Impart(6, 2));
        }
    }
}
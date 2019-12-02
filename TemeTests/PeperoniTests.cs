using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curs15.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator.Tests
{
    [TestClass()]
    public class PeperoniTests
    {
        [TestMethod()]
        public void GetCostTest()
        {
            var peperoniMozzapizza = new Peperoni() { Component = new Mozzarella() { Component = new Pizza() } };
            Assert.AreEqual(23, peperoniMozzapizza.GetCost());
            var CuDeToate = new Shrooms();
            CuDeToate.Component = peperoniMozzapizza;
            Assert.AreEqual(26, CuDeToate.GetCost());
        }
    }
}
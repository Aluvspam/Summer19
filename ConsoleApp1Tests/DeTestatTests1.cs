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
    public class DeTestatTests1
    {
        DeTestat TestObj = new DeTestat();
        [TestMethod()]        
        public void ImpartireTest()
        {
            Assert.AreNotEqual(50, TestObj.Impartire(100, 4));
        }
    }
}
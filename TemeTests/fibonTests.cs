﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme.Tests
{
    [TestClass()]
    public class fibonTests
    {
        [TestMethod()]
        public void FibTest()

        {
            var testfib = new fibon();
            Assert.AreEqual(6,testfib.fibon(4));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT.Tests
{
    [TestClass()]
    public class DanielPlayer2Tests
    {
        [TestMethod()]
        public void FirstMoveTest()
        {
            var player = new DanielPlayer2();
            Assert.AreNotEqual(Moves.B, player.FirstMove());
        }
    }
}
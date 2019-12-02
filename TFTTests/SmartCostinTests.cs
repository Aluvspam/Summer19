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
    public class SmartCostinTests
    {
        [TestMethod()]
        public void ScoreGameTest()
        {
            var player = new Costin();
            player.ScoreGame(Moves.C, Moves.C);
            Assert.AreEqual(3, player.Score);
        }
    }
}
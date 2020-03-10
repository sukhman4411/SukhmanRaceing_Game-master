 using Microsoft.VisualStudio.TestTools.UnitTesting;
using SukhmanRaceing_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanRaceing_Game.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Batter3 obj = new Batter3();
            obj.getData(40);
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void Better2Test()
        {
            Better1 obj = new Better1();
            obj.getData(40);
            Assert.IsTrue(true);
        }

    }
}
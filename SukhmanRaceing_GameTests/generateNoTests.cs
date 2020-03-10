﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SukhmanRaceing_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanRaceing_Game.Tests
{
    [TestClass()]
    public class generateNoTests
    {
        [TestMethod()]
        public void generateRandomNoTest()
        {
            generateNo obj_gen = new generateNo();
            int sth = obj_gen.generateRandomNo();
            Assert.IsTrue(sth < 36);
        }

        [TestMethod()]
        public void generateRandomNoTest2()
        {
            generateNo obj_gen = new generateNo();
            int sth = obj_gen.generateRandomNo();
            Assert.IsTrue(sth >= 0);
        }
    }
}
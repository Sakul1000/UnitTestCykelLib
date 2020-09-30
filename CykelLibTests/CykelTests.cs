using Microsoft.VisualStudio.TestTools.UnitTesting;
using CykelLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CykelLib.Tests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel cykel;

        [TestInitialize]
        public void Init()
        {
            cykel = new Cykel();
        }

        [TestMethod()]
        public void CykelFarveTest()
        {
            cykel.Farve = "gul";
            Assert.AreEqual("gul",cykel.Farve);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Farve = "");
        }

        [TestMethod()]
        public void CykelPrisTest()
        {
            cykel.Pris = 10;
            Assert.AreEqual(10, cykel.Pris);
            Assert.ThrowsException<ArgumentException>(() => cykel.Pris = 0);
        }

        [TestMethod()]
        public void CykelGearTest()
        {
            cykel.Gear = 30;
            Assert.AreEqual(30, cykel.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel.Gear = 33);
        }

    }
}
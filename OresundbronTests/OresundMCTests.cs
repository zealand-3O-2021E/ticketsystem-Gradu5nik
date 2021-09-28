using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.Tests
{
    [TestClass()]
    public class OresundMCTests
    {
        [TestMethod()]
        public void CheckPriceMethod()
        {
            double pris = new OresundMC().Price();
            Assert.AreEqual(210, pris);
        }

        [TestMethod()]
        public void CheckPriceMethodBrobuzz()
        {
            double pris = new OresundMC() { Brobuzz = true }.Price();
            Assert.AreEqual(73, pris, 0.1);
        }
        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new OresundMC().VeichleType();
            Assert.AreEqual("Oresund Motorcycle", type);
        }
    }
}
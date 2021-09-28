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
    public class OresundCarTests
    {
        [TestMethod()]
        public void CheckPriceMethod()
        {
            double pris = new OresundCar().Price();
            Assert.AreEqual(410, pris);
        }

        [TestMethod()]
        public void CheckPriceMethodBrobuzz()
        {
            double pris = new OresundCar() {Brobuzz=true}.Price();
            Assert.AreEqual(161, pris, 0.1);
        }
        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new OresundCar().VeichleType();
            Assert.AreEqual("Oresund Car", type);
        }
    }
}
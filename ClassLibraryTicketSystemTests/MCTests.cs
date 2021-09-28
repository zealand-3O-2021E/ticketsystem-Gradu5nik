using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void ChechPriceMethod()
        {
            double pris = new MC().Price();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new MC().VeichleType();
            Assert.AreEqual("Motorcycle", type);
        }
    }
}
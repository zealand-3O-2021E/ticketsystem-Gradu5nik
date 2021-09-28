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
        public void CheckPriceMethod()
        {
            double pris = new MC().Price();
            Assert.AreEqual(125, pris);
        }
        [TestMethod()]
        public void CheckPriceMethodBrobuzz()
        {
            double pris = new MC() { Brobuzz=true}.Price();
            Assert.AreEqual(118.75, pris,0.1);
        }

        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new MC().VeichleType();
            Assert.AreEqual("Motorcycle", type);
        }
    }
}
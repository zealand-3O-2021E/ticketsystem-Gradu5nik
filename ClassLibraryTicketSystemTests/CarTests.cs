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
    public class CarTests
    {
        [TestMethod()]
        public void ChechPriceMethod()
        {
            double pris = new Car().Price(); 
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new Car().VeichleType();
            Assert.AreEqual("Car",type);
        }
    }
}
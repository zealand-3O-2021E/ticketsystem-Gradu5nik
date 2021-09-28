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
        public void CheckPriceMethod()
        {
            double pris = new Car().Price(); 
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void CheckPriceMethodBrobuzz()
        {
            double pris = new Car() {Brobuzz=true }.Price();
            Assert.AreEqual(228, pris, 0.1);
        }
        [TestMethod()]
        public void CheckVeichleTypeMethod()
        {
            string type = new Car().VeichleType();
            Assert.AreEqual("Car",type);
        }
        [TestMethod()]
        [DataRow("I2E4567")]
        public void LicensePlateTestSuccess(string LP) 
        {
            Car testCar = new() { LicensePlate = LP };
            Assert.AreEqual(LP, testCar.LicensePlate);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow("I2E4567B")]
        public void LicensePlateTestFail(string LP)
        {
            Car testCar = new() { LicensePlate = LP };
            
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class CarStorebeltTests
    {
        [TestMethod()]
        [DataRow(2021,09,28)]
        [DataRow(2021, 09, 29)]
        [DataRow(2021, 09, 30)]
        [DataRow(2021, 10, 1)]
        public void CheckStorebeltCarPrice(int y,int m, int d)
        {
            DateTime dat = new DateTime(y, m, d);
            double pris = new CarStorebelt() { Brobuzz = false, Date = dat }.Price();
            Assert.AreEqual(240, pris);
        }
        [TestMethod()]
        [DataRow(2021, 10, 2)]
        [DataRow(2021, 10, 3)]
        public void CheckStorebeltCarPriceWeekend(int y, int m, int d)
        {
            DateTime dat = new DateTime(y, m, d);
            double pris = new CarStorebelt() { Brobuzz = false, Date = dat }.Price();
            Assert.AreEqual(192, pris,0.1);
        }
        [TestMethod()]
        [DataRow(2021, 10, 2)]
        [DataRow(2021, 10, 3)]
        public void CheckStorebeltWeekendBrobuzz(int y, int m, int d)
        {
            DateTime dat = new DateTime(y, m, d);
            double pris = new CarStorebelt() { Brobuzz=true, Date=dat}.Price();
            Assert.AreEqual(182.4, pris,0.1);
        }
        
    }
}
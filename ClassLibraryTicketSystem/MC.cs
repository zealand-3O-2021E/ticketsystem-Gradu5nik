using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }


        public double Price()
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 125</returns>
        {
            return 125;
        }
        public string VeichleType()
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Motorcylce</returns>
        {
            return "Motorcycle";
        }
    }
}


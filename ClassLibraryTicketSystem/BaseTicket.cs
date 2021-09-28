using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class BaseTicket
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }


        public virtual double Price()
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>double</returns>
        {
            return 0;
        }
        public virtual string VeichleType()
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string </returns>
        {
            return "";
        }
    }
}

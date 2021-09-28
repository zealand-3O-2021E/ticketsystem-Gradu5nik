using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class BaseTicket
    {
        private string _licensePlate;

        /// <summary>
        /// Throws exception if you try to set licenseplate longer than 7 cahracters
        /// </summary>
        public string LicensePlate

        {
            get { return _licensePlate; }
            set 
            { 
                try 
                {
                    if (value.Length > 7)
                        throw new ArgumentException("LicensePlate should not be longer than 7 characters");
                    _licensePlate = value; 
                }
                catch (ArgumentException) { throw; }
            }
        }

        public DateTime Date { get; set; }

        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>double</returns>
        public abstract double Price();
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string </returns>
        public abstract string VeichleType();
    }
}

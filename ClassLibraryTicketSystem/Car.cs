using System;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        
        
        public  double Price()
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 240</returns>
        {
            return 240;
        }
        public string VeichleType()
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Car</returns>
        {
            return "Car";
        }
    }
}

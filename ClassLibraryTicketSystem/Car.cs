using System;

namespace ClassLibraryTicketSystem
{
    public class Car :BaseTicket
    {
        
        public override double Price()
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 240</returns>
        {
            int price = 240;
            if (Brobuzz) return Discount(price);
            return price;
        }
        public override string VeichleType()
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Car</returns>
        {
            return "Car";
        }

    }
}

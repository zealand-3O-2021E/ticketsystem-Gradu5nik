using System;

namespace ClassLibraryTicketSystem
{
    public class Car :BaseTicket
    {
        
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 240</returns>
        public override double Price()
        
        {
            int price = 240;
            if (Brobuzz) return Discount(price,broBuzzDiscount);
            return price;
        }
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Car</returns>
        public override string VeichleType()
        
        {
            return "Car";
        }

    }
}

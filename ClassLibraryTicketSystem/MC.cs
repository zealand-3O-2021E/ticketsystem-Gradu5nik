using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC:BaseTicket
    {


        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 125</returns>
        public override double Price()
        
        {
            int price = 125;
            if (Brobuzz) return Discount(price,broBuzzDiscount);
            return price;
        }
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Motorcylce</returns>
        public override string VeichleType()
        {

            return "Motorcycle";
        }
    }
}


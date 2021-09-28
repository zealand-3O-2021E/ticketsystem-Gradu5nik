using System;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class OresundCar:BaseTicket
    {
        public override double Price()

        {
            int price = 410;
            if (Brobuzz) return 161;
            return price;
        }
        public override string VeichleType()
        {

            return "Oresund Car";
        }
    }
}

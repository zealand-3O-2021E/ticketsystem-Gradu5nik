using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace Oresundbron
{
    public class OresundMC:BaseTicket
    {
        public override double Price()

        {
            int price = 210;
            if (Brobuzz) return 73;
            return price;
        }
        public override string VeichleType()
        {

            return "Oresund Motorcycle";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC:BaseTicket
    {


        public override double Price()
        /// <summary>
        /// method returns the price of the crossing
        /// </summary>
        /// <returns>number 125</returns>
        {
            return 125;
        }
        public override string VeichleType()
        /// <summary>
        /// returns the type of crossing veichle
        /// </summary>
        /// <returns>string - Motorcylce</returns>
        {
            return "Motorcycle";
        }
    }
}

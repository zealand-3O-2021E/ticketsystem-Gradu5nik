using System;
using ClassLibraryTicketSystem;
namespace StoreBaeltTicketLibrary
{
    public class CarStorebelt:Car
    {
        public const int weekendDiscount=20;
        public override double Price()
        {
            double price = 240;
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price = Discount(price, weekendDiscount);
            }
            if (Brobuzz)
            {
                price = Discount(price);
            }
            return price;
        }
        
    }
}

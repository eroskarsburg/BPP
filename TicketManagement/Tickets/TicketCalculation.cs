using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Tickets
{
    public class TicketCalculation
    {
        Ticket ticket = new Ticket();
        public double _value { get; set; }


        public double PaymentMethodCalculation(double price)
        {
            double FIVE_PERCENT_DISCOUNT = price * 0.05;

            Console.WriteLine("> 5% of Discount.");
            return price - FIVE_PERCENT_DISCOUNT;
        }

        public double ChairCalculation(int chairValue, double priceValue)
        {
            bool DiscountChairs = chairValue > 0 && chairValue <= 20;

            if (DiscountChairs)
            {
                double FIFTEEN_PERCENT_DISCOUNT = _value * 0.15;

                _value -= FIFTEEN_PERCENT_DISCOUNT;
                priceValue = _value;
            }

            return priceValue;
        }


    }
}

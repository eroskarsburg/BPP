using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Tickets;

namespace TicketManagement.StrategyMethod.Strategy.PaymentTypes
{
    public class PIXStrategy : IPayment
    {
        public double CalculatePrice(double price)
        {
            double FIVE_PERCENT_DISCOUNT = price * 0.05;

            Console.WriteLine("> 5% of Discount.");
            return price - FIVE_PERCENT_DISCOUNT;
        }
    }
}

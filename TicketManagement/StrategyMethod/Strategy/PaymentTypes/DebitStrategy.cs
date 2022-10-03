using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.StrategyMethod.Strategy.PaymentTypes
{
    public class DebitStrategy : IPayment
    {
        public double CalculatePrice(double price)
        {
            double THREE_PERCENT_ASCENT = price * 0.03;

            Console.WriteLine("> 3% of Discount.");
            return price - THREE_PERCENT_ASCENT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.StrategyMethod.Strategy.PaymentTypes
{
    public class CreditStrategy : IPayment
    {
        public double CalculatePrice(double price)
        {
            double FIVE_PERCENT_READJUSTMENT = price * 0.05;

            Console.WriteLine("> 5% of Additional service rate.");
            return price + FIVE_PERCENT_READJUSTMENT;
        }
    }
}

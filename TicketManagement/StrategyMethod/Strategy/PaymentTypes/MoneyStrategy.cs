using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.StrategyMethod.Strategy.PaymentTypes
{
    public class MoneyStrategy : IPayment
    {
        public double CalculatePrice(double price)
        {
            Console.WriteLine("Without Discount or Additional rate.");
            return price;
        }
    }
}

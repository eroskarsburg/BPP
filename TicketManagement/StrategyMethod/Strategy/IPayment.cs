using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.StrategyMethod.Strategy
{
    public interface IPayment
    {
        public double CalculatePrice(double price);
    }
}

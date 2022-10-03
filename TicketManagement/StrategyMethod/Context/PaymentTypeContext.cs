using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.StrategyMethod.Strategy;
using TicketManagement.StrategyMethod.Strategy.PaymentTypes;

namespace TicketManagement.StrategyMethod.Context
{
    public class PaymentTypeContext
    {
        public IPayment GetStrategyPayment(string paymentType)
        {
            if (paymentType == "MONEY")
            {
                return new MoneyStrategy();
            }
            if (paymentType == "CREDIT")
            {
                return new CreditStrategy();
            }
            if (paymentType == "DEBIT")
            {
                return new DebitStrategy();
            }
            if (paymentType == "PIX")
            {
                return new PIXStrategy();
            }

            throw new Exception("Invalid payment method.");
        }
    }
}

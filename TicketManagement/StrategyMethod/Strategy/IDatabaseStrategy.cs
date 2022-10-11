using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.StrategyMethod.Strategy
{
    public interface IDatabaseStrategy
    {
        public string Save();
    }
}

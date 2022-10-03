using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Tickets
{
    public class Ticket
    {
        public string TicketType { get; set; }
        public string PaymentMethod { get; set; }
        public int ChairNumber { get; set; }
        public string DatabaseSaver { get; set; }
    }
}

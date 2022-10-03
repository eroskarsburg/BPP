using System;
using TicketManagement.DependencyInversion.Databases;
using TicketManagement.DependencyInversion.Databases.System;
using TicketManagement.TemplateMethod.ClientExecuter;
using TicketManagement.TemplateMethod.PaymentTypes;
using TicketManagement.Tickets;

namespace TicketManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client.ClientCode(new PaymentGenerationMethods());
        }
    }
}

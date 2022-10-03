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
            Console.WriteLine("Starting Operation...");
            Client.ClientCode(new PaymentGenerationMethods());

            Console.Write("\n");

            //Console.WriteLine("Operação com CRÉDITO:");
            //Client.ClientCode(new Credit());

            //Console.Write("\n");

            //Console.WriteLine("Operação com DÉBITO:");
            //Client.ClientCode(new Debit());
        }
    }
}

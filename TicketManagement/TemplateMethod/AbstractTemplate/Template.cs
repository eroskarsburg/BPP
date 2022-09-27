using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.TemplateMethod.AbstractTemplate
{
    public abstract class Template
    {
        // Design Pattern: TEMPLATE

        public void InitialTemplate()
        {
            this.TemplatePaymentMethod();
            this.ChosePaymentMethod();
            this.TemplateChair();
            this.ChoseChair();
        }

        protected void TemplatePaymentMethod()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("- MONEY");
            Console.WriteLine("- CREDIT");
            Console.WriteLine("- DEBIT");
            Console.WriteLine("- PIX");
        }

        protected void TemplateChair()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("Enter the CHAIR number:");
        }

        protected void TemplateTicket()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("What kind of Ticket do you want?\n");
            Console.WriteLine("- NORMAL");
            Console.WriteLine("- RETIRED");
            Console.WriteLine("- ARMY");
            Console.WriteLine("- OLD MAN");
        }

        protected void TemplateDataBase()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("- ORACLE");
            Console.WriteLine("- MYSQL");
            Console.WriteLine("- SQL");
            Console.WriteLine("- PHP");
        }
        protected abstract void ChosePaymentMethod();

        protected abstract void ChoseChair();

        protected abstract void ChoseTicketType();

        protected abstract void ChoseDatabaseSaver();
    }
}

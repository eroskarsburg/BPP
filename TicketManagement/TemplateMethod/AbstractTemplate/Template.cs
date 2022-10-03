﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.TemplateMethod.AbstractTemplate
{
    public abstract class Template
    {
        // Design Pattern: TEMPLATE

        public void TemplateGenerator()
        {
            this.TemplatePaymentMethod();
            this.ChosePaymentMethod();
            this.TemplateChair();
            this.ChoseChair();
            this.TemplateTicketType();
            this.ChoseTicketType();
            this.TemplateDatabaseSaver();
            this.ChoseDatabaseSaver();
            this.TemplatePriceInformer();
            this.PriceInformation();
            this.NFEGenerator();
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
            Console.WriteLine("Enter the Chair number:");
        }

        protected void TemplateTicketType()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("What kind of Ticket do you desire?\n");
            Console.WriteLine("- NORMAL");
            Console.WriteLine("- RETIRED");
            Console.WriteLine("- ARMY");
            Console.WriteLine("- OLD MAN");
        }

        protected void TemplateDatabaseSaver()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("- ORACLE");
            Console.WriteLine("- MYSQL");
            Console.WriteLine("- SQL");
            Console.WriteLine("- PHP");
        }

        protected void TemplatePriceInformer()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("Enter the payment price:");
        }

        protected void TemplateNFEGenerator()
        {
            Console.WriteLine("\n=---------=");
            Console.WriteLine("Generating Note...");
        }

        protected abstract void ChosePaymentMethod();

        protected abstract void ChoseChair();

        protected abstract void ChoseTicketType();

        protected abstract void ChoseDatabaseSaver();

        protected abstract void PriceInformation();

        protected abstract void NFEGenerator();
    }
}

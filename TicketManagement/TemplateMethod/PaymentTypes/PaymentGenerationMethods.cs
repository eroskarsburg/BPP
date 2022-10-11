using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.DependencyInversion.Databases.System;
using TicketManagement.StrategyMethod.Context;
using TicketManagement.StrategyMethod.Strategy;
using TicketManagement.TemplateMethod.AbstractTemplate;
using TicketManagement.Tickets;
using TicketManagement.Visualinterface;

namespace TicketManagement.TemplateMethod.PaymentTypes
{
    public class PaymentGenerationMethods : Template
    {
        PaymentTypeContext paymentTypeContext = new PaymentTypeContext();
        DatabaseTypeContext databaseTypeContext = new DatabaseTypeContext();
        Ticket ticket = new Ticket();
        Header header = new Header();
        Footer footer = new Footer();
        private string chosenPaymentMethod;
        private int chosenChairNumber;
        private string chosenTicketType;
        private string chosenDatabase;
        private double informedPrice;

        protected override void ChosePaymentMethod()
        {
            chosenPaymentMethod = Console.ReadLine().ToUpper();
        }

        protected override void ChoseChair()
        {
            chosenChairNumber = int.Parse(Console.ReadLine());
        }

        protected override void ChoseTicketType()
        {
            chosenTicketType = Console.ReadLine().ToUpper();
        }

        protected override void ChoseDatabaseSaver()
        {
            chosenDatabase = Console.ReadLine().ToUpper();
        }

        protected override void PriceInformation()
        {
            informedPrice = double.Parse(Console.ReadLine());
        }

        protected override void NFEGenerator()
        {
            IPayment payment = paymentTypeContext.GetStrategyPayment(chosenPaymentMethod);
            DatabaseSystem database = databaseTypeContext.GetStrategyDatabase(chosenDatabase);
            double paymentResult = payment.CalculatePrice(informedPrice);
            database.Save(new Ticket());
            Console.WriteLine($"Result with {chosenPaymentMethod} method: {paymentResult} R$");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;
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
            double result = payment.CalculatePrice(informedPrice);
            Console.WriteLine($"Result with {chosenPaymentMethod} method: {result} R$");
        }
    }
}

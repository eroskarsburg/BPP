using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.TemplateMethod.AbstractTemplate;

namespace TicketManagement.TemplateMethod.PaymentTypes
{
    public class Money : Template
    {
        protected override void ChosePaymentMethod()
        {
            Console.WriteLine("");
        }

        protected override void ChoseChair()
        {
            
        }
    }
}

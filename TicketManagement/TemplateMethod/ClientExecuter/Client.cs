using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.TemplateMethod.AbstractTemplate;

namespace TicketManagement.TemplateMethod.ClientExecuter
{
    public class Client
    {
        public static void ClientCode(Template template)
        {
            template.TemplateGenerator();
        }
    }
}

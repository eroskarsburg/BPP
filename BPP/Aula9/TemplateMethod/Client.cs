using BPP.Aula9.TemplateMethod.AbstractTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.TemplateMethod
{
    public class Client
    {
        public static void ClientCode(Template template)
        {
            template.TemplateMth();
        }
    }
}

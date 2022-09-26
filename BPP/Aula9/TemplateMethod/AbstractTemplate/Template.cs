using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.TemplateMethod.AbstractTemplate
{
    public abstract class Template
    {
        public void TemplateMth()
        {
            this.Temp1();
            this.GenericOperation();
            this.Temp2();
            this.GenericOperation2();
        }

        // Operações com implementações padrão.
        protected void Temp1()
        {
            Console.WriteLine("Template: 1");
        }

        protected void Temp2()
        {
            Console.WriteLine("Template: 2");
        }

        // São operações que serão implementadas em subclasses herdando Template.
        protected abstract void GenericOperation();

        protected abstract void GenericOperation2();
    }
}

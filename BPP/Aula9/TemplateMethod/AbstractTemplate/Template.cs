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

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}

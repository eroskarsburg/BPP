using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using BPP.Aula9.TemplateMethod;
using BPP.Aula9.TemplateMethod.CreditMethod;
using BPP.Aula9.TemplateMethod.DebitMethod;
using BPP.Aula9.TemplateMethod.PIXMethod;
using System;

namespace BPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Operação com PIX:");
            Client.ClientCode(new PIX());

            Console.Write("\n");

            Console.WriteLine("Operação com CRÉDITO:");
            Client.ClientCode(new Credit());

            Console.Write("\n");

            Console.WriteLine("Operação com DÉBITO:");
            Client.ClientCode(new Debit());
        }
    }
}

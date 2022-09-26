using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using BPP.Aula9.TemplateMethod.AbstractTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.TemplateMethod.CreditMethod
{
    public class Credit : Template
    {
        TipoPagamentoContext pagamentoContext = new TipoPagamentoContext();

        protected override void GenericOperation()
        {
            Console.WriteLine("-------------------\nExecutando CRÉDITO\n");
            IPagamento tipoPagamento = pagamentoContext.getStrategyPagamento("CREDITO");
            double resultado = tipoPagamento.Calcular(50);
            Console.WriteLine($"Resultado utilizando CRÉDITO: {resultado}");
        }

        protected override void GenericOperation2()
        {
            Console.WriteLine("\nFinalizando Transação no CRÉDITO...\n-------------------");
        }
    }
}

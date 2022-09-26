using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using BPP.Aula9.TemplateMethod.AbstractTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.TemplateMethod.DebitMethod
{
    public class Debit : Template
    {
        TipoPagamentoContext pagamentoContext = new();

        protected override void GenericOperation()
        {
            Console.WriteLine("-------------------\nExecutando DÉBITO\n");
            IPagamento tipoPagamento = pagamentoContext.getStrategyPagamento("DEBITO");
            double resultado = tipoPagamento.Calcular(100);
            Console.WriteLine($"Resultado utilizando DÉBITO: {resultado}");
        }

        protected override void GenericOperation2()
        {
            Console.WriteLine("\nFinalizando Transação no DÉBITO...\n-------------------");
        }
    }
}

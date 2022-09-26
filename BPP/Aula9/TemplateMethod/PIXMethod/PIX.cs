using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using BPP.Aula9.TemplateMethod.AbstractTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.TemplateMethod.PIXMethod
{
    public class PIX : Template
    {
        TipoPagamentoContext pagamentoContext = new();

        protected override void GenericOperation()
        {
            Console.WriteLine("-------------------\nExecutando PIX\n");
            IPagamento tipoPagamento = pagamentoContext.getStrategyPagamento("PIX");
            double resultado = tipoPagamento.Calcular(150);
            Console.WriteLine($"Resultado utilizando PIX: {resultado}");
        }

        protected override void GenericOperation2()
        {
            Console.WriteLine("\nFinalizando Transação no PIX...\n-------------------");
        }
    }
}

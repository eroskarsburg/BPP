using BPP.Aula9.StrategySystem.Context;
using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using System;

namespace BPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PagamentoContext pagamentoContext = new PagamentoContext();
            IPagamento tipoPagamento = pagamentoContext.getStrategyPagamento("Credito");
            double resultado = tipoPagamento.Calcular(50);
            Console.WriteLine($"Resultado utilizando CRÉDITO: {resultado}");


            tipoPagamento = pagamentoContext.getStrategyPagamento("Debito");
            resultado = tipoPagamento.Calcular(100);
            Console.WriteLine($"Resultado utilizando DÉBITO: {resultado}");


            tipoPagamento = pagamentoContext.getStrategyPagamento("PIX");
            resultado = tipoPagamento.Calcular(140);
            Console.WriteLine($"Resultado utilizando PIX: {resultado}");
        }
    }
}

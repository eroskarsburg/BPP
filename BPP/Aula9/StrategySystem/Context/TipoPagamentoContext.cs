using BPP.Aula9.StrategySystem.Strategy.TiposPagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.StrategySystem.Context
{
    public class TipoPagamentoContext
    {
        public IPagamento getStrategyPagamento(string tipoPagamento)
        {
            if (tipoPagamento == "CREDITO")
            {
                return new CreditoStrategy();
            }
            if (tipoPagamento == "DEBITO")
            {
                return new DebitoStrategy();
            }
            if (tipoPagamento == "PIX")
            {
                return new PIXStrategy();
            }

            throw new Exception("Tipo de Pagamento inválido.");
        }

        public double CalcularPagamento(string tipoPagamento, double valor)
        {
            if (tipoPagamento == "CREDITO")
            {
                return new CreditoStrategy().Calcular(valor);
            }
            if (tipoPagamento == "DEBITO")
            {
                return new DebitoStrategy().Calcular(valor);
            }
            if (tipoPagamento == "PIX")
            {
                return new PIXStrategy().Calcular(valor);
            }

            throw new Exception("Tipo de Pagamento incorreto.");
        }
    }
}

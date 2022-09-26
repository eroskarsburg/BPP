using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.StrategySystem.Strategy.TiposPagamento
{
    public class CreditoStrategy : IPagamento
    {
        public double Calcular(double valor)
        {
            return (valor * 35) / 100;
        }
    }
}

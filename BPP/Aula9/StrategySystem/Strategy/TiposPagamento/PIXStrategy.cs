using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.StrategySystem.Strategy.TiposPagamento
{
    public class PIXStrategy : IPagamento
    {
        public double Calcular(double valor)
        {
            return (valor * 40) / 100;
        }
    }
}

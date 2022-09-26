using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Aula9.StrategySystem.Strategy.TiposPagamento
{
    public interface IPagamento
    {
        public double Calcular(double valor);
    }
}

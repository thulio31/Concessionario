using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario
{
    public interface IVeiculos
    {
        void ExibirDetalhes();
        double CalcularConsumo(double distancia);
    }
}

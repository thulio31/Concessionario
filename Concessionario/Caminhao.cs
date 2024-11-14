using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoPorKm, double capacidadeCarga)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            CapacidadeCarga = capacidadeCarga;
        }
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"CapacidadeCarga : {CapacidadeCarga} toneladas");
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoCombustivel = base.CalcularConsumo(distancia);
            return consumoCombustivel / CapacidadeCarga * ConsumoPorKm;
        }
    }
}

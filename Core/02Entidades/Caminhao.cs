using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario
{
    [Table("Caminhaos")]
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao()
            :base()
        {
                
        }
        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoPorKm, double capacidadeCarga)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            CapacidadeCarga = capacidadeCarga;
        }
        public override string ExibirDetalhes()
        {
            string mensagemDetalhes = base.ExibirDetalhes();
            mensagemDetalhes += $"CapacidadeCarga : {CapacidadeCarga} toneladas";
            return mensagemDetalhes;
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoCombustivel = base.CalcularConsumo(distancia);
            return consumoCombustivel / CapacidadeCarga * ConsumoPorKm;
        }
    }
}

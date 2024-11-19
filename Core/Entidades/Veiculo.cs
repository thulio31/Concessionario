    using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario
{
    public class Veiculo : IVeiculos
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoPorKm { get; set; }

        public Veiculo(string modelo, int ano, double capacidadeTanque, double consumoPorKm)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            ConsumoPorKm = consumoPorKm;
        }

        public virtual string ExibirDetalhes()
        {
            string mensagemExibirDetalhes = $"=-=-=-=-=-=-=-=-=- Detalhes -=-=-=-=-=-=-=-=-=-" +
                $"\nModelo: {Modelo}" +
                $"\nAno: {Ano}" +
                $"\nCapacidade do Tanque: {CapacidadeTanque} lts" +
                $"\nConsumo por Km: {ConsumoPorKm} km";

            return mensagemExibirDetalhes;
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }
}

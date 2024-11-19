using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionario
{
    public class Carro : Veiculo
    {
        public string Tipo { get; set; }

        public Carro(string modelo, int ano, double capacidadeTanque, double consumoPorKm, string tipo)
            : base(modelo, ano, capacidadeTanque,consumoPorKm) 
        {
            Tipo= tipo;
        }  
        public override string ExibirDetalhes()
        {
            string mensagenDetalhes = base.ExibirDetalhes();
            mensagenDetalhes += $"Tipo : {Tipo}";
            return mensagenDetalhes;
        }

        public override double CalcularConsumo(double distancia)
        {
            Console.WriteLine("Qual e o tipo \n1 - Hibrido  2 - Normal");
            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                return distancia / ConsumoPorKm / 2.00;
            }
            else
            {
                return distancia / ConsumoPorKm;
            }
        }
    }
}

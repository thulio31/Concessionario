using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ICarroService
    {
        void Adicionar(Carro carro);
        Carro BuscarCarroPorId(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        void Remover(int id);
    }
}

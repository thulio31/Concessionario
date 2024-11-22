using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface ICarroRepository
    {
        void Adicionar(Carro carro);
        List<Carro> Listar();
        void Editar(Carro carro);
        void Remover(int id);
        Carro Buscar(int id);
    }
}

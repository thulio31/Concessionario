using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01Service
{
    public interface ICarroService
    {
        void Adicionar(Carro Carro);
        void Remover(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        Carro BuscarCarroPorId(int id);
    }
}

using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01Service
{
    public interface ICaminhaoService
    {
        void Adicionar(Carro carro);
        void Remover(int id);
        List<Carro> Listar();
        Carro BuscarTimePorId(int id);
        void Editar(Carro editcar);
    }
}

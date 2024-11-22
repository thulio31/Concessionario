using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface ICaminhaoService
    {
        void Adicionar(Caminhao caminhao);
        Caminhao BuscarPorId(int id);
        void Editar(Caminhao caminhao);
        List<Caminhao> Listar();
        void Remover(int id);

    }
}

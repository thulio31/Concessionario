using Concessionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public interface ICaminhaoRepository
    {
        void Adicionar(Caminhao caminhao);
        List<Caminhao> Listar();
        void Editar(Caminhao caminhao);
        void Delete(int id);
        Caminhao Buscar(int id);
    }
}

using Concessionario;
using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01Service
{
    public class CaminhaoService : ICaminhaoService
    {
        private readonly ICaminhaoRepository repository;
        public CaminhaoService(ICaminhaoRepository _repository)
        {
            repository = _repository;
        }

        public void Adicionar(Caminhao caminhao)
        {
            repository.Adicionar(caminhao);
        }

        public Caminhao BuscarPorId(int id)
        {
            return repository.Buscar(id);
        }

        public void Editar(Caminhao caminhao)
        {
            repository.Editar(caminhao);
        }

        public List<Caminhao> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Delete(id);
        }
    }
}

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
    public class CarroService : ICarroService
    {
        private readonly ICarroRepository repository;
        public CarroService(ICarroRepository _repository)
        {
            repository = _repository;
        }

        public void Adicionar(Carro carro)
        {
            repository.Adicionar(carro);
        }

        public Carro BuscarPorId(int id)
        {
            return repository.Buscar(id);
        }

        public void Editar(Carro carro)
        {
            repository.Editar(carro);
        }

        public List<Carro> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Delete(id);
        }
    }
}

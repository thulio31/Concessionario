using Concessionario;
using Core._02Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._01Service
{
    public class CarroService : ICarroService
    {
        public ICarroRepository repository { get; set; }
        public CarroService(ICarroRepository _repository)
        {
            repository = _repository;
        }
        public void Adicionar(Carro carro)
        {
            repository.Adicionar(carro);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Carro> Listar()
        {
            return repository.Listar();
        }
        public Carro BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Carro editcar)
        {
            repository.Editar(editcar);
        }
    }
}

using Concessionario;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{
    public class CarroRepository : ICarroRepository
    {
        private readonly string ConnectionString;

        public CarroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(carro);
        }

        public List<Carro> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carro>().ToList();
        }

        public void Editar(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carro>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carro novocarro = Buscar(id);
            connection.Delete(novocarro);
        }

        public Carro Buscar(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carro>(id);
        }


    }
}

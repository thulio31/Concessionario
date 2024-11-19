using Concessionario;
using Core._02Repository.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02Repository
{
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly string ConnectionString;

        public CaminhaoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Caminhao caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Caminhao>(caminhao);
        }

        public List<Caminhao> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Caminhao>().ToList();
        }

        public void Editar(Caminhao caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString); 
            connection.Update<Caminhao>(caminhao);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString); 
            Caminhao novocaminhao = Buscar(id); 
            connection.Delete<Caminhao>(novocaminhao);
        }

        public Caminhao Buscar(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Caminhao>(id);
        }
    }
}

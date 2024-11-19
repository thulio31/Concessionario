using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class InicializadorBD
    {
        private const string ConnectionString = "Data Source = Concesionaria.db";
        public static void Inializador()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Caminhaos(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Modelo TEXT NOT NULL,
                Ano INTEGER NOT NULL,
                CapacidadeTanque REAL NOT NULL,
                ConsumoPorKm REAL NOT NULL,
                CapacidadeCarga REAL NOT NULL
                 );";

                connection.Execute(commandoSQL);

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Carros(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Modelo TEXT NOT NULL,
                Ano INTEGER NOT NULL,
                CapacidadeTanque REAL NOT NULL,
                ConsumoPorKm REAL NOT NULL,
                Tipo TEXT NOT NULL
                 );";

                connection.Execute(commandoSQL);
            }            
        }
    }
}
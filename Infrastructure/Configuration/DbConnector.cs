using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public abstract class DbConnector
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=basetest;Uid=usuario;Pwd=password;Allow Zero Datetime=True;Convert Zero Datetime=True;CheckParameters=false";
        protected MySqlConnection connection;
        protected MySqlCommand command;

        public DbConnector()
        {
            connection = new MySqlConnection(connectionString);
            command = new MySqlCommand();
        }

        public async Task Conectar()
        {
            if(connection == null)
                connection = new MySqlConnection(connectionString);

            await connection.OpenAsync();
            command.Connection = connection;
        }

        public async Task Desconectar()
        {
            await connection.CloseAsync();
        }
    }
}

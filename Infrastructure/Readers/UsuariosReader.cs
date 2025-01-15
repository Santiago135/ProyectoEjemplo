using Domain;
using Infrastructure.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Readers
{
    public class UsuariosReader : DbConnector
    {
        public async Task<List<Usuario>> GetUsuarios()
        {
            try
            {
                List<Usuario> lista = new();

                await Conectar();

                using (var command = new MySqlCommand("SELECT * FROM usuarios", connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(reader["id"]);
                                usuario.Name = reader["name"].ToString();
                                lista.Add(usuario);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

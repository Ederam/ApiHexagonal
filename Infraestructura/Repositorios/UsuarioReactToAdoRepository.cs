using Dominio.Entidades;
using Dominio.Repositorios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class UsuarioReactToAdoRepository : IUsuarioReactToAdoRepository
    {
        private readonly string _connectionString;

        public UsuarioReactToAdoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<UsuarioReactToAdo>> ObtenerUsuariosReactToAdoAsync()
        {
            var usuariosReact = new List<UsuarioReactToAdo>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("select * from UsuariosReact", connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            usuariosReact.Add(new UsuarioReactToAdo
                            {
                                id = reader.GetInt32(0),
                                apellido_paterno = reader.GetString(1),
                                apellido_materno = reader.GetString(2),
                                nombre = reader.GetString(3),                                
                                correo = reader.GetString(2),
                                username = reader.GetString(4),
                                password = reader.GetString(5)
                            });
                        }
                    }
                }
            }

            return usuariosReact;
        }
    }
}

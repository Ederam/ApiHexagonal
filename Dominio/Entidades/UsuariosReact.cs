using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class UsuariosReact
    {
        public int id { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        // Constructor sin parámetros
        public UsuariosReact() { }

        public UsuariosReact(int id, string apellidoPaterno, string apellidoMaterno, string nombre, string correo, string username, string password)
        {
            this.id = id;
            this.apellido_paterno = apellidoPaterno;
            this.apellido_materno = apellidoMaterno;
            this.nombre = nombre;
            this.correo = correo;
            this.username = username;
            this.password = password;
        }
    }
}

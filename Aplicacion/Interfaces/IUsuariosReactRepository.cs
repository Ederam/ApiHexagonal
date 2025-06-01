using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IUsuariosReactRepository
    {
        void Guardar(UsuariosReact usuarioReact);
        UsuariosReact ObtenerPorId(int id);
    }
}

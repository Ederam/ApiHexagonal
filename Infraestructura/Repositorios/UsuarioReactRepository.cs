using Aplicacion.Interfaces;
using Dominio.Entidades;
using Infraestructura.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class UsuarioReactRepository : IUsuariosReactRepository
    {
        private readonly AppDbContext _context;

        public UsuarioReactRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Guardar(UsuariosReact usuarioReact)
        {
            _context.UsuariosReact.Add(usuarioReact);
            _context.SaveChanges();
        }

        public UsuariosReact ObtenerPorId(int id)
        {
            return _context.UsuariosReact.FirstOrDefault(p => p.id == id);
        }
    }
}

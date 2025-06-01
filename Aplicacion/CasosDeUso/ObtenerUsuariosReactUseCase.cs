using Aplicacion.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CasosDeUso
{
    public class ObtenerUsuariosReactUseCase
    {
        private readonly IUsuariosReactRepository _usuariosReactRepository;
        public ObtenerUsuariosReactUseCase(IUsuariosReactRepository usuariosReactRepository)
        {
            _usuariosReactRepository = usuariosReactRepository;
        }
        public UsuariosReact Ejecutar(int id)
        {
            return _usuariosReactRepository.ObtenerPorId(id);
        }
    }
}

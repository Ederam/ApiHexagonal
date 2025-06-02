using Dominio.Entidades;
using Dominio.Repositorios;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Queries
{
    public class ObtenerUsuariosReactToAdoQuery : IRequest<IEnumerable<UsuarioReactToAdo>> {}

    public class ObtenerUsuariosReactToAdoQueryHandler : IRequestHandler<ObtenerUsuariosReactToAdoQuery, IEnumerable<UsuarioReactToAdo>>
    {
        private readonly IUsuarioReactToAdoRepository _usuarioReactToAdoRepository;

        public ObtenerUsuariosReactToAdoQueryHandler(IUsuarioReactToAdoRepository usuarioReactToAdoRepository)
        {
            _usuarioReactToAdoRepository = usuarioReactToAdoRepository;
        }

        public async Task<IEnumerable<UsuarioReactToAdo>> Handle(ObtenerUsuariosReactToAdoQuery request, CancellationToken cancellationToken)
        {
            return await _usuarioReactToAdoRepository.ObtenerUsuariosReactToAdoAsync();
        }
    }


}

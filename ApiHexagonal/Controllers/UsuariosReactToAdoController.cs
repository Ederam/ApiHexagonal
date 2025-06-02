using Aplicacion.Queries;
using Dominio.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiHexagonal.Controllers
{
    [ApiController]
    [Route("api/usuariosReactToAdo")]
    public class UsuariosReactToAdoController : Controller
    {
        private readonly IMediator _mediator;

        public UsuariosReactToAdoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioReactToAdo>>> ObtenerUsuariosReactToAdo()
        {
            var usuarios = await _mediator.Send(new ObtenerUsuariosReactToAdoQuery());
            return Ok(usuarios);
        }
    }
}

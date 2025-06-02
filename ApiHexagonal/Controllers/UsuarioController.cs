using Aplicacion.CasosDeUso;
using Microsoft.AspNetCore.Mvc;

namespace ApiHexagonal.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : Controller
    {
        private readonly ObtenerUsuariosReactUseCase _obtenerUsuariosReactUseCase;

        public UsuarioController(ObtenerUsuariosReactUseCase obtenerUsuariosReactUseCase)
        {
            _obtenerUsuariosReactUseCase = obtenerUsuariosReactUseCase;
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerUsuarioReact(int id)
        {
            var usuarioReact = _obtenerUsuariosReactUseCase.Ejecutar(id);
            return usuarioReact != null ? Ok(usuarioReact) : NotFound();
        }
    }

}

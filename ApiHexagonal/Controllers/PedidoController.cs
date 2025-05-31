using Aplicacion.CasosDeUso;
using Microsoft.AspNetCore.Mvc;

namespace ApiHexagonal.Controllers
{
    [ApiController]
    [Route("api/pedidos")]
    public class PedidoController : ControllerBase
    {
        private readonly ObtenerPedidoUseCase _obtenerPedidoUseCase;

        public PedidoController(ObtenerPedidoUseCase obtenerPedidoUseCase)
        {
            _obtenerPedidoUseCase = obtenerPedidoUseCase;
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPedido(int id)
        {
            var pedido = _obtenerPedidoUseCase.Ejecutar(id);
            return pedido != null ? Ok(pedido) : NotFound();
        }
    }
}

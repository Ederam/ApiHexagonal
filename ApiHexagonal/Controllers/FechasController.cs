using Aplicacion.DTOs;
using Aplicacion.Servicios.Mapeadores;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ApiHexagonal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FechasController : Controller
    {
        [HttpPost("mapear")]
        public ActionResult<List<FechaPropuesta>> MapearFechas([FromBody] List<FechasPropuestasDto> fechasDto)
        {
            try
            {
                var entidades = FechaPropuestaMapper.MapearDesdeDto(fechasDto);
                return Ok(entidades);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*
         [
          {
            "fechaEstimadaEntrega": "2025-06-10T00:00:00",
            "observacion": "Entrega tentativa"
          },
          {
            "fechaEstimadaEntrega": "2025-06-12T00:00:00",
            "observacion": "Posible segunda entrega"
          }
        ]
 
         */
    }
}

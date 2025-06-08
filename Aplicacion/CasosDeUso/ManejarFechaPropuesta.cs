using Aplicacion.DTOs;
using Aplicacion.Servicios.Mapeadores;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CasosDeUso
{
    public class ManejarFechaPropuesta
    {
        public void Ejecutar(List<FechasPropuestasDto> dtos)
        {
            List<FechaPropuesta> entidades = FechaPropuestaMapper.MapearDesdeDto(dtos);

            // Aquí podrías llamar a un Puerto de salida o procesar la lógica de negocio
        }
    }
}

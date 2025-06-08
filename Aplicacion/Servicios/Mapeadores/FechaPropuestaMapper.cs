using Aplicacion.DTOs;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios.Mapeadores
{
    public static class FechaPropuestaMapper
    {
        public static List<FechaPropuesta> MapearDesdeDto(List<FechasPropuestasDto> dtos)
        {
            if (dtos == null) return new();

            return dtos
                .Select(dto => FechaPropuesta.Crear(dto.FechaEstimadaEntrega, dto.Observacion))
                .ToList();
        }
    }
}

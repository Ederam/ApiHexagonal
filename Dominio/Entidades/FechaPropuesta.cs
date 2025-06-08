using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class FechaPropuesta
    {
        public DateTime Fecha { get; private set; }
        public string Observacion { get; private set; }

        private FechaPropuesta(DateTime fecha, string observacion)
        {
            Fecha = fecha;
            Observacion = observacion;
        }

        public static FechaPropuesta Crear(DateTime fecha, string observacion)
        {
            if (fecha < DateTime.Today)
                throw new ArgumentException("La fecha no puede estar en el pasado.");

            return new FechaPropuesta(fecha, observacion);
        }
    }
}

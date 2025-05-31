using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; private set; }
        public string Cliente { get; private set; }
        public DateTime FechaCreacion { get; private set; }

        public Pedido(int id, string cliente)
        {
            Id = id;
            Cliente = cliente;
            FechaCreacion = DateTime.UtcNow;
        }
    }
}

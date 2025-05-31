using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IPedidoRepository
    {
        void Guardar(Pedido pedido);
        Pedido ObtenerPorId(int id);
    }
}

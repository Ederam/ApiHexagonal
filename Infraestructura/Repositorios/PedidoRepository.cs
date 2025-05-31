using Aplicacion.Interfaces;
using Dominio.Entidades;
using Infraestructura.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Guardar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public Pedido ObtenerPorId(int id)
        {
            return _context.Pedidos.FirstOrDefault(p => p.Id == id);
        }
    }
}

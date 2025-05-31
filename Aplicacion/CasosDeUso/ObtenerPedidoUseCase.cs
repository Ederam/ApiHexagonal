using Aplicacion.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.CasosDeUso
{
    public class ObtenerPedidoUseCase
    {
        private readonly IPedidoRepository _repository;

        public ObtenerPedidoUseCase(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public Pedido Ejecutar(int pedidoId)
        {
            return _repository.ObtenerPorId(pedidoId);
        }
    }
}

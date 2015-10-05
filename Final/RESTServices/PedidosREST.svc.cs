using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    public class PedidosREST : IPedidosREST
    {
        private PedidoDAO dao = new PedidoDAO();

        public Pedido CrearPedido(Pedido pedidoACrear)
        {
            if ("1".Equals(pedidoACrear.Numero))
            {
                throw new WebFaultException<string>(
                    "Pedido imposible", HttpStatusCode.HttpVersionNotSupported);
            }
            return dao.Crear(pedidoACrear);
        }

        public Pedido ObtenerPedido(string numero)
        {
            //return dao.Obtener(Convert.ToInt32(numero));
            return dao.Obtener(numero);
        }

        public Pedido ModificarPedido(Pedido pedidoAModificar)
        {
            return dao.Modificar(pedidoAModificar);
        }

        public void EliminarPedido(string numero)
        {
              dao.Eliminar(numero);
        }

        public List<Pedido> ListarPedidos()
        {
            return dao.ListarTodos();
        }


        public List<Pedido> ListarPedidos2(string numero)
        {
            return dao.ListarTodos2(numero);
        }
    }
}

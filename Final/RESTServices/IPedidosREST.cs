using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    [ServiceContract]
    public interface IPedidosREST
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Pedidos", ResponseFormat = WebMessageFormat.Json)]
        Pedido CrearPedido(Pedido pedidoACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Pedidos/{numero}", ResponseFormat = WebMessageFormat.Json)]
        Pedido ObtenerPedido(string numero);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        Pedido ModificarPedido(Pedido pedidoAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Pedidos/{numero}")]
        void EliminarPedido(string numero);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarPedidos", ResponseFormat = WebMessageFormat.Xml)]
        List<Pedido> ListarPedidos();
    }
}

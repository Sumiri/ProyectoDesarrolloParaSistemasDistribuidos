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
    public interface IFacturas
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Facturas", ResponseFormat = WebMessageFormat.Json)]
        Factura CrearPedido(Factura facturaACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Facturas/{numero}", ResponseFormat = WebMessageFormat.Json)]
        Factura ObtenerPedido(string numero);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Facturas", ResponseFormat = WebMessageFormat.Json)]
        Factura ModificarFactura(Factura facturaAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Facturas/{numero}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void EliminarFactura(string numero);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Facturas", ResponseFormat = WebMessageFormat.Xml)]
        List<Pedido> ListarFacturas();
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarPedidos2/{numero}", ResponseFormat = WebMessageFormat.Xml)]
        List<Pedido> ListarFacturas2(string numero);
    }
}

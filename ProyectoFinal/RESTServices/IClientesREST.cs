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
    public interface IClientesREST
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        Cliente CrearCliente(Cliente clienteACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Cliente ObtenerCliente(string codigo);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        Cliente ModificarCliente(Cliente clienteAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Clientes/{codigo}")]
        void EliminarCliente(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        List<Cliente> ListarClientes();
    }
}

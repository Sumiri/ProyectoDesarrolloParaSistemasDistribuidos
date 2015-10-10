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
    public interface IComisionesREST
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Comisiones", ResponseFormat = WebMessageFormat.Json)]
        Comision CrearComision(Comision comisionACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Comisiones/{numero}", ResponseFormat = WebMessageFormat.Json)]
        Comision ObtenerComision(string numero);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Comisiones", ResponseFormat = WebMessageFormat.Json)]
        Comision ModificarComision(Comision comisionAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Comisiones/{numero}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void EliminarComision(string numero);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarComisiones", ResponseFormat = WebMessageFormat.Xml)]
        List<Comision> ListarComisiones();
    }
}

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
    public interface IUsuariosREST
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        Usuario CrearUsuario(Usuario usuarioACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Usuario ObtenerUsuario(string codigo);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        Usuario ModificarUsuario(Usuario usuarioAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Usuarios/{codigo}")]
        void EliminarUsuario(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Usuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ListarUsuarios();
    }
}

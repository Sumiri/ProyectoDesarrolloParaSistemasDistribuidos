using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    [ServiceContract]
    public interface IArticulos
    {
        [OperationContract]
        Articulo CrearArticulo(string descripcion);
        [OperationContract]
        Articulo ObtenerArticulo(int codigo);
        [OperationContract]
        Articulo ModificarArticulo(int codigo, string descripcion);
        [OperationContract]
        void EliminarArticulo(int codigo);
        [OperationContract]
        List<Articulo> ListarArticulos();
    }
}

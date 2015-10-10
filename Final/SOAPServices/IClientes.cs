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
    public interface IClientes
    {
        [OperationContract]
        Cliente CrearCliente(string razonsocial, string correo);
        [OperationContract]
        Cliente ObtenerCliente(int codigo);
        [OperationContract]
        Cliente ModificarCliente(int codigo, string razonsocial, string correo);
        [OperationContract]
        void EliminarCliente(int codigo);
        [OperationContract]
        List<Cliente> ListarClientes();  
    }
}

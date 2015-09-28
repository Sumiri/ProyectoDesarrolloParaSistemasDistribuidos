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
    public class ClientesREST : IClientesREST
    {
        private ClienteDAO dao = new ClienteDAO();

        public Cliente CrearCliente(Cliente clienteACrear)
        {
            if ("1".Equals(clienteACrear.Codigo))
            {
                throw new WebFaultException<string>(
                    "Cliente imposible", HttpStatusCode.HttpVersionNotSupported);
            }
            return dao.Crear(clienteACrear);
        }

        public Cliente ObtenerCliente(string codigo)
        {
            //return dao.Obtener(Convert.ToInt32(codigo));
            return dao.Obtener(codigo);
        }

        public Cliente ModificarCliente(Cliente clienteAModificar)
        {
            return null;
        }

        public void EliminarCliente(string codigo)
        {

        }

        public List<Cliente> ListarClientes()
        {
            return null;
        }
    }
}

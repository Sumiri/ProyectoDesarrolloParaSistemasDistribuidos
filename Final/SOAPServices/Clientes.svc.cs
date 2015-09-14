using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;

namespace SOAPServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO clienteDAO = null;
        private ClienteDAO ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDAO();
                return clienteDAO;        
            }

        }


        /*private ClienteDAO ClienteDAO
        /*{
            get
            {
                if (clienteDAO == null)
                {
                    clienteDAO = new ClienteDAO();
                    return clienteDAO;
                }
            }
        }*/

        public Cliente CrearCliente(string razonsocial, string correo)
        {
            Cliente clienteACrear = new Cliente()
            {
                RazonSocial = razonsocial,
                Correo = correo
            };
            return ClienteDAO.Crear(clienteACrear);
        }

        public Cliente ObtenerCliente(int codigo)
        {
            return ClienteDAO.Obtener(codigo);
        }

        public Cliente ModificarCliente(int codigo, string razonsocial, string correo)
        {
            Cliente clienteAModificar = new Cliente()
            {
                RazonSocial = razonsocial,
                Correo = correo
            };
            return ClienteDAO.Modificar(clienteAModificar);
        }

        public void EliminarCliente(int codigo)
        {
            Cliente clienteExistente = ClienteDAO.Obtener(codigo);
            ClienteDAO.Eliminar(clienteExistente);
        }

        public List<Cliente> ListarClientes()
        {
            return ClienteDAO.ListarTodos().ToList();
        }
    }
}   

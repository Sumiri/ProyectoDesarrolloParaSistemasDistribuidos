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

    public class Facturas : IFacturas
    {
        private FacturaDAO dao = new FacturaDAO();

        public Factura CrearFactura(Factura facturaACrear)
        {
            if ("11".Equals(facturaACrear.Numero))
            {
                throw new WebFaultException<string>(
                    "Cliente moroso", HttpStatusCode.HttpVersionNotSupported);
            }
            return dao.Crear(facturaACrear);
        }

        public Factura ObtenerFactura(string numero)
        {
            return dao.Obtener(numero);
        }

        public Factura ModificarFactura(Factura facturaAModificar)
        {
            throw new NotImplementedException();
        }

        public void EliminarFactura(string numero)
        {
            throw new NotImplementedException();
        }

        public List<Factura> ListarFacturas()
        {
            throw new NotImplementedException();
        }

        public List<Factura> ListarFacturas2(string numero)
        {
            throw new NotImplementedException();
        }



        List<Pedido> IFacturas.ListarFacturas2(string numero)
        {
            throw new NotImplementedException();
        }
    }
}

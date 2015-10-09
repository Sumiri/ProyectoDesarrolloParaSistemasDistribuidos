using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTServices
{
    
    public class Facturas : IFacturas
    {
    

        public Dominio.Factura CrearPedido(Dominio.Factura facturaACrear)
        {
            throw new NotImplementedException();
        }

        public Dominio.Factura ObtenerPedido(string numero)
        {
            throw new NotImplementedException();
        }

        public Dominio.Factura ModificarFactura(Dominio.Factura facturaAModificar)
        {
            throw new NotImplementedException();
        }

        public void EliminarFactura(string numero)
        {
            throw new NotImplementedException();
        }

        public List<Dominio.Pedido> ListarFacturas()
        {
            throw new NotImplementedException();
        }

        public List<Dominio.Pedido> ListarFacturas2(string numero)
        {
            throw new NotImplementedException();
        }
    }
}

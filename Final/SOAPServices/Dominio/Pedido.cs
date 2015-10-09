using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int CodCompania { get; set; }
        [DataMember]
        public int CodSucursalCia { get; set; }
        [DataMember]
        public int Ano { get; set; }
        [DataMember]
        public int NumeroPedido { get; set; }
        [DataMember]
        public DateTime FecPedido { get; set; }
        [DataMember]
        public int CodCliente { get; set; }
        [DataMember]
        public int CodSucursal { get; set; }
        [DataMember]
        public string CodUsuarioVendedor { get; set; }
        [DataMember]
        public int CodDocumentoFacturacion { get; set; }
        [DataMember]
        public string NumeroOrdenCompra { get; set; }
        [DataMember]
        public int CodMoneda { get; set; }
        [DataMember]
        public double ImporteTotalBruto { get; set; }
        [DataMember]
        public double ImporteTotalDescuento { get; set; }
        [DataMember]
        public double PorcentajeIGV { get; set; }
        [DataMember]
        public double ImporteTotalIGV { get; set; }
        [DataMember]
        public double ImporteTotalNeto { get; set; }
        [DataMember]
        public int CodEstadoAtencion { get; set; }
        [DataMember]
        public int CodAlmacen { get; set; }
        [DataMember]
        public int CodEstadoRegistro { get; set; }
        [DataMember]
        public string CodUsuarioCreador { get; set; }
        [DataMember]
        public DateTime FecCreacion { get; set; }
        [DataMember]
        public string CodUsuarioUpdate { get; set; }
        [DataMember]
        public DateTime FecUpdate { get; set; }
    }
}

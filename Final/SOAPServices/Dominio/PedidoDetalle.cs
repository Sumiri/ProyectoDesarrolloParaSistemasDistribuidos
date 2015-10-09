using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class PedidoDetalle
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
        public int NumeroItem { get; set; }
        [DataMember]
        public int CodItemArticulo { get; set; }
        [DataMember]
        public int UnidadesPedidas { get; set; }
        [DataMember]
        public int UnidadesComprometidas { get; set; }
        [DataMember]
        public double ImportePrecioUnitarioSIGV { get; set; }
        [DataMember]
        public double ImportePrecioUnitarioCIGV { get; set; }
        [DataMember]
        public double ImporteSubtotalBruto { get; set; }
        [DataMember]
        public double PorcentajeDescuento { get; set; }
        [DataMember]
        public double ImporteSubtotalDescuento { get; set; }
        [DataMember]
        public double ImporteSubtotalNeto { get; set; }
        [DataMember]
        public int CodEstadoAtencion { get; set; }
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

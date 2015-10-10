using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Factura
    {
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Fecha { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string ImporteBruto { get; set; }
        [DataMember]
        public string ImporteVenta { get; set; }
        [DataMember]
        public string ImporteIGV { get; set; }
        [DataMember]
        public string ImporteTotalVenta { get; set; }

    }
}
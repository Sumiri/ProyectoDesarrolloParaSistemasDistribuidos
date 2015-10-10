using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Anho { get; set; }
        [DataMember]
        public string Fecha { get; set; }
        [DataMember]
        public string Cliente { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Moneda { get; set; }
        [DataMember]
        public string Importe { get; set; }
    }
}
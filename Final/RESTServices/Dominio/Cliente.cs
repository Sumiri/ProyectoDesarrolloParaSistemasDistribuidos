using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string Correo { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public string CodUsuario { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string PrimerNombre { get; set; }
    }
}
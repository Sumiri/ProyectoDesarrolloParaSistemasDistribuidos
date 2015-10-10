using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Comision
    {
        [DataMember]
        public string CodUsuarioVendedor { get; set; }
        [DataMember]
        public string DesUsuario { get; set; }
        [DataMember]
        public string ImporteSolVendido { get; set; }
        [DataMember]
        public string PorcentajeComision { get; set; }
        [DataMember]
        public string ImporteComisionSol { get; set; }
        /*[DataMember]
        public string ImporteComisionUsd { get; set; }*/

    }
}
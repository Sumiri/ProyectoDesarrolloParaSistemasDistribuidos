using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            // return "Data Source=(local);Initial Catalog=BD_Pedidos;Integrated Security=SSPI;";
            //return "Data Source=.;Initial Catalog=BD_Pedidos;Integrated Security=SSPI;";
            //return "Data Source=DESARROLLO_PC;Initial Catalog=BD_Pedidos;Integrated Security=SSPI;";
            //return "Server=DESARROLLO_PC\\SQL2008R2;Database=BD_Pedidos;User Id=raponte; Password=xzfqxt";
            return "Server=JAIME-PC\\SQL2008R2;Database=BD_Pedidos;User Id=raponte; Password=xzfqxt";
        }
    }
}
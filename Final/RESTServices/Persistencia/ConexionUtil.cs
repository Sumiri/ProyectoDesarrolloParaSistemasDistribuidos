using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {
                //return "Data Source=CASA\\SQLEXPRESS;Initial Catalog=BD_Pedidos;Integrated Security=True";
                //return "Data Source=.;Initial Catalog=BD_Pedidos;Integrated Security=SSPI;";
                //return "Data Source=DESARROLLO_PC;Initial Catalog=BD_Pedidos;Integrated Security=SSPI;";
                //return "Server=DESARROLLO_PC\\SQL2008R2;Database=BD_Pedidos;User Id=raponte; Password=xzfqxt";
               return "Server=JAIME-PC\\SQL2008R2;Database=BD_Pedidos;User Id=jgutierrez; Password=xzfqxt";
                //return "Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=BD_Pedidos;Integrated Security=True";
               // return "Data Source=WSVIJIMENEZ\\SQLEXPRESS;Database=BD_Pedidos;User Id=vjimenez; Password=vji2002";
            }
        }
    }
}
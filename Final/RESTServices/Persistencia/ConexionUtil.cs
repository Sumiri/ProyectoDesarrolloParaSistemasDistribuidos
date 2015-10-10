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
                //return "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_PEDIDOS;Integrated Security=True";
                //return "Server=JAIME-PC\\SQL2008R2;Database=BD_Pedidos;User Id=jgutierrez; Password=xzfqxt";
                return "Server=localhost\\SQLEXPRESS; Database = BD_Asesores; User Id=vjimenez;Password=vji2002"; 

            }
        }
    }
}
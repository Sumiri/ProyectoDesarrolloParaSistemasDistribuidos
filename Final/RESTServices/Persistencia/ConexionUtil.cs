﻿using System;
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
                return "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_PEDIDOS;Integrated Security=True";
            }
        }
    }
}
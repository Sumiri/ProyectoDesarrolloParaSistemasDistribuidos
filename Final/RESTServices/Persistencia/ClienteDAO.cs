using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ClienteDAO
    {


        public Cliente Crear(Cliente clienteACrear)
        {
            //Cliente clienteCreado = null;
            //string sql = "INSERT INTO t_cliente VALUES (@cod, @nom)";
            //using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            //{
            //    con.Open();
            //    using (SqlCommand com = new SqlCommand(sql, con))
            //    {
            //        com.Parameters.Add(new SqlParameter("@cod", clienteACrear.Codigo));
            //        com.Parameters.Add(new SqlParameter("@nom", clienteACrear.Nombre));
            //        com.ExecuteNonQuery();
            //    }
            //}
            //clienteCreado = Obtener(clienteACrear.Codigo);
            //return clienteCreado;
            return null;
        }
        public Cliente Obtener(string codigo)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM CLIENTE WHERE COD_CLIENTE=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                Codigo = (string)Convert.ToString(resultado["COD_CLIENTE"]),
                                Correo = (string)resultado["CORREO"],
                                RazonSocial = (string)resultado["RAZON_SOCIAL"]
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }
        public Cliente Modificar(Cliente clienteAModificar)
        {

            return null;
        }
        public void Eliminar(string codigo)
        {
            //string sql = "DELETE * FROM t_cliente WHERE codigo=@codigo";
            //using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            //{
            //    con.Open();
            //    using (SqlCommand com = new SqlCommand(sql, con)) ;
            //}    
        }
        public List<Cliente> ListarTodos()
        {
            return null;
        }

    }
}
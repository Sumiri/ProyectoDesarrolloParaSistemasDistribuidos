using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace RESTServices.Persistencia
{
    public class ComisionDAO
    {
        public Comision Crear(Comision comisionACrear)
        {
            return null;
        }
        public Comision Obtener(string numero)
        {
            Comision comisionEncontrado = null;
            //string sql = "SELECT * FROM COMISION_VENDEDOR WHERE mes=@num";
            string sql = "SELECT COD_USUARIO_VENDEDOR, SUM(IMPORTE_SOL_VENDIDO) AS IMPORTE_SOL_VENDIDO, MAX(PORCENTAJE_COMISION) AS PORCENTAJE_COMISION, SUM(IMPORTE_COMISION_SOL) AS IMPORTE_COMISION_SOL FROM COMISION_VENDEDOR WHERE mes=@num GROUP BY COD_USUARIO_VENDEDOR";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@num", numero));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            comisionEncontrado = new Comision()
                            {
                                CodUsuarioVendedor = (string)Convert.ToString(resultado["COD_USUARIO_VENDEDOR"]),
                                //DesUsuario = (string)Convert.ToString(resultado["FEC_PEDIDO"]),
                                //ImporteComisionUsd = (string)Convert.ToString(resultado["IMPORTE_COMISION_USD"]),
                                ImporteSolVendido = (string)Convert.ToString(resultado["IMPORTE_SOL_VENDIDO"]),
                                PorcentajeComision = (string)Convert.ToString(resultado["PORCENTAJE_COMISION"]),
                                ImporteComisionSol = (string)Convert.ToString(resultado["IMPORTE_COMISION_SOL"])
                            };
                        }
                    }
                }
            }
            return comisionEncontrado;
        }
        public Comision Modificar(Comision comisionAModificar)
        {
            return null;
        }
        public void Eliminar(string numero)
        {
        }
        public List<Comision> ListarTodos()
        {
            List<Comision> Comisiones = new List<Comision>();
            Comision comisionEncontrado = null;
            // "SELECT * FROM COMISION_VENDEDOR WHERE COD_ESTADO_REGISTRO=1";
            string sql = "SELECT COD_USUARIO_VENDEDOR, SUM(IMPORTE_SOL_VENDIDO) AS IMPORTE_SOL_VENDIDO, MAX(PORCENTAJE_COMISION) AS PORCENTAJE_COMISION, SUM(IMPORTE_COMISION_SOL) AS IMPORTE_COMISION_SOL FROM COMISION_VENDEDOR WHERE COD_ESTADO_REGISTRO = 1 GROUP BY COD_USUARIO_VENDEDOR";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            comisionEncontrado = new Comision()
                            {
                                CodUsuarioVendedor = (string)Convert.ToString(resultado["COD_USUARIO_VENDEDOR"]),
                                //ImporteComisionUsd = (string)Convert.ToString(resultado["IMPORTE_COMISION_USD"]),
                                ImporteSolVendido = (string)Convert.ToString(resultado["IMPORTE_SOL_VENDIDO"]),
                                PorcentajeComision = (string)Convert.ToString(resultado["PORCENTAJE_COMISION"]),
                                ImporteComisionSol = (string)Convert.ToString(resultado["IMPORTE_COMISION_SOL"])
                            };

                            //Buscar Usuario Vendedor
                            HttpWebRequest req = WebRequest.Create("http://localhost:23440/UsuariosREST.svc/Usuarios/" + Convert.ToString(resultado["COD_USUARIO_VENDEDOR"]))
                                as HttpWebRequest;
                            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                            StreamReader reader = new StreamReader(res.GetResponseStream());
                            string usuarioJson = reader.ReadToEnd();
                            JavaScriptSerializer js = new JavaScriptSerializer();
                            Usuario usuarioEncontrado = js.Deserialize<Usuario>(usuarioJson);

                            comisionEncontrado.DesUsuario = usuarioEncontrado.PrimerNombre + " " + usuarioEncontrado.ApellidoPaterno;

                            Comisiones.Add(comisionEncontrado);
                        }
                    }
                }
            }
            return Comisiones;
        }

    }
}
using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Runtime.Serialization;
using System.Text;
using System.Web.Script.Serialization;

namespace RESTServices.Persistencia
{
    public class PedidoDAO
    {
        public Pedido Crear(Pedido pedidoACrear)
        {
            return null;
        }
        public Pedido Obtener(string numero)
        {
            Pedido pedidoEncontrado = null;
            string sql = "SELECT * FROM PEDIDO WHERE NUMERO_PEDIDO=@num";
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
                            pedidoEncontrado = new Pedido()
                            {
                                Numero = (string)Convert.ToString(resultado["NUMERO_PEDIDO"]),
                                Fecha = (string)Convert.ToString(resultado["FEC_PEDIDO"]),
                                CodCliente = (string)Convert.ToString(resultado["COD_CLIENTE"]),
                                Moneda = (string)Convert.ToString(resultado["COD_MONEDA"]),
                                Importe = (string)Convert.ToString(resultado["IMPORTE_TOTAL_NETO"])
                            };
                        }
                    }
                }
            }
            return pedidoEncontrado;
        }
        public Pedido Modificar(Pedido pedidoAModificar)
        {
            Pedido pedidoModificado = null;
            string sql = "UPDATE PEDIDO SET FEC_PEDIDO = @fec,COD_MONEDA = @mon WHERE NUMERO_PEDIDO = @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@fec", pedidoAModificar.Fecha));
                    com.Parameters.Add(new SqlParameter("@mon", pedidoAModificar.Moneda));
                    com.Parameters.Add(new SqlParameter("@cod", pedidoAModificar.Numero));
                    com.ExecuteNonQuery();
                }
            }
            pedidoModificado = Obtener(pedidoAModificar.Numero);
            return pedidoModificado;
        }
        public void Eliminar(string numero)
        {
            string sql = "DELETE PEDIDO WHERE NUMERO_PEDIDO = @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", numero));
                    com.ExecuteNonQuery();
                }
            }
        }
        public List<Pedido> ListarTodos()
        {
            

            List<Pedido> Pedidos = new List<Pedido>();
            Pedido pedidoEncontrado = null;
            string sql = "SELECT * FROM PEDIDO WHERE COD_ESTADO_ATENCION=1";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            pedidoEncontrado = new Pedido()
                            {
                                Numero = (string)Convert.ToString(resultado["NUMERO_PEDIDO"]),
                                Fecha = (string)Convert.ToString(resultado["FEC_PEDIDO"]),
                                CodCliente = (string)Convert.ToString(resultado["COD_CLIENTE"]),
                                Moneda = (string)Convert.ToString(resultado["COD_MONEDA"]),
                                Importe = (string)Convert.ToString(resultado["IMPORTE_TOTAL_NETO"])
                            };

                            //Buscar Cliente

                            HttpWebRequest req = WebRequest.Create("http://localhost:23440/ClientesREST.svc/Clientes/" + Convert.ToString(resultado["COD_CLIENTE"])) 
                                as HttpWebRequest;
                            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                            StreamReader reader = new StreamReader(res.GetResponseStream());
                            string clienteJson = reader.ReadToEnd();
                            JavaScriptSerializer js = new JavaScriptSerializer();
                            Cliente clienteEncontrado = js.Deserialize<Cliente>(clienteJson);

                            pedidoEncontrado.Cliente = clienteEncontrado.RazonSocial;
                            pedidoEncontrado.Direccion = clienteEncontrado.Direccion;

                            if (pedidoEncontrado.Moneda=="1")
                                pedidoEncontrado.Moneda="S/.";
                            if (pedidoEncontrado.Moneda == "2")
                                pedidoEncontrado.Moneda = "US$";                                                        
                            Pedidos.Add(pedidoEncontrado);
                        }
                    }
                }
            }
            return Pedidos;
        }


        public List<Pedido> ListarTodos2(string numero)
        {


            List<Pedido> Pedidos = new List<Pedido>();
            Pedido pedidoEncontrado = null;
            string sql = "SELECT * FROM PEDIDO WHERE ANO=@date";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@date", numero));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            pedidoEncontrado = new Pedido()
                            {
                                Numero = (string)Convert.ToString(resultado["NUMERO_PEDIDO"]),
                                Anho = (string)Convert.ToString(resultado["ANO"]),
                                Fecha = (string)Convert.ToString(resultado["FEC_PEDIDO"]),
                                CodCliente = (string)Convert.ToString(resultado["COD_CLIENTE"]),
                                Moneda = (string)Convert.ToString(resultado["COD_MONEDA"]),
                                Importe = (string)Convert.ToString(resultado["IMPORTE_TOTAL_NETO"])
                            };

                            //Buscar Cliente

                            HttpWebRequest req = WebRequest.Create("http://localhost:23440/ClientesREST.svc/Clientes/" + Convert.ToString(resultado["COD_CLIENTE"]))
                                as HttpWebRequest;
                            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                            StreamReader reader = new StreamReader(res.GetResponseStream());
                            string clienteJson = reader.ReadToEnd();
                            JavaScriptSerializer js = new JavaScriptSerializer();
                            Cliente clienteEncontrado = js.Deserialize<Cliente>(clienteJson);

                            pedidoEncontrado.Cliente = clienteEncontrado.RazonSocial;
                            pedidoEncontrado.Direccion = clienteEncontrado.Direccion;

                            if (pedidoEncontrado.Moneda == "1")
                                pedidoEncontrado.Moneda = "S/.";
                            if (pedidoEncontrado.Moneda == "2")
                                pedidoEncontrado.Moneda = "US$";
                            Pedidos.Add(pedidoEncontrado);
                        }
                    }
                }
            }
            return Pedidos;
        }
    }
}
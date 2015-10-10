using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class FacturaDAO
    {
        public Factura Crear(Factura facturaGuardar)
        {
            Factura facturaCreado = null;
            string sql = "INSERT INTO FACTURA_CABECERA  (NUMERO_DOCUMENTO,FEC_EMISION,COD_CLIENTE,IMPORTE_TOTAL_BRUTO,IMPORTE_VALOR_VENTA,IMPORTE_IGV,IMPORTE_TOTAL_NETO)  VALUES (@num,@fec,@cli,@bruto,@venta,@igv,@net);";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@num", facturaGuardar.Numero));
                    com.Parameters.Add(new SqlParameter("@fec", facturaGuardar.Fecha));
                    com.Parameters.Add(new SqlParameter("@cli", facturaGuardar.Cliente));
                    com.Parameters.Add(new SqlParameter("@bruto", facturaGuardar.ImporteBruto));
                    com.Parameters.Add(new SqlParameter("@venta", facturaGuardar.ImporteVenta));
                    com.Parameters.Add(new SqlParameter("@igv", facturaGuardar.ImporteIGV));
                    com.Parameters.Add(new SqlParameter("@net", facturaGuardar.ImporteTotalVenta));
                    com.ExecuteNonQuery();
                }
            }
            facturaCreado = Obtener(facturaGuardar.Numero);
            EstadoPedido(facturaGuardar.Numero);
            return facturaCreado;
        }



        public Factura Obtener(string numero)
        {
            Factura facturaEncontrada = null;
            string sql = "SELECT * FROM FACTURA_CABECERA WHERE NUMERO_DOCUMENTO=@num";
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
                            facturaEncontrada = new Factura()
                            {
                                Numero = (string)Convert.ToString(resultado["NUMERO_DOCUMENTO"]),
                                Cliente = (string)Convert.ToString(resultado["COD_CLIENTE"]),
                                Fecha = (string)Convert.ToString(resultado["FEC_EMISION"]),
                                ImporteBruto = (string)Convert.ToString(resultado["IMPORTE_TOTAL_BRUTO"]),
                                ImporteVenta = (string)Convert.ToString(resultado["IMPORTE_VALOR_VENTA"]),
                                ImporteIGV = (string)Convert.ToString(resultado["IMPORTE_IGV"]),
                                ImporteTotalVenta = (string)Convert.ToString(resultado["IMPORTE_TOTAL_NETO"])
                            };
                        }
                    }
                }
            }
            return facturaEncontrada;
        }

        public void EstadoPedido(string numero)
        {
            string sql = "UPDATE PEDIDO SET COD_ESTADO_ATENCION=2 WHERE NUMERO_PEDIDO=@cod";
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
    }
}
using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class UsuarioDAO
    {
        public Usuario Crear(Usuario usuarioACrear)
        {
            return null;
        }
        public Usuario Obtener(string codigo)
        {
            Usuario usuarioEncontrado = null;
            string sql = "SELECT * FROM Usuario WHERE COD_USUARIO=@cod";
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
                            usuarioEncontrado = new Usuario()
                            {
                                CodUsuario = (string)Convert.ToString(resultado["COD_USUARIO"]),
                                ApellidoPaterno = (string)resultado["APELLIDO_PATERNO"],
                                PrimerNombre = (string)resultado["PRIMER_NOMBRE"]
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }
        public Usuario Modificar(Usuario usuarioAModificar)
        {
            return null;
        }
        public void Eliminar(string codigo)
        {
        }
        public List<Usuario> ListarTodos()
        {
            return null;
        }
    }
}
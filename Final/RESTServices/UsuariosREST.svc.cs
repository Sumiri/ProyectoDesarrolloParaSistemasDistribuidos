using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    public class UsuariosREST : IUsuariosREST
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public Usuario CrearUsuario(Usuario usuarioACrear)
        {
            if ("1".Equals(usuarioACrear.CodUsuario))
            {
                throw new WebFaultException<string>(
                    "Usuario imposible", HttpStatusCode.HttpVersionNotSupported);
            }
            return dao.Crear(usuarioACrear);
        }

        public Usuario ObtenerUsuario(string codigo)
        {
            //return dao.Obtener(Convert.ToInt32(codigo));
            return dao.Obtener(codigo);
        }

        public Usuario ModificarUsuario(Usuario usuarioAModificar)
        {
            return null;
        }

        public void EliminarUsuario(string codigo)
        {

        }

        public List<Usuario> ListarUsuarios()
        {
            return null;
        }
    }
}

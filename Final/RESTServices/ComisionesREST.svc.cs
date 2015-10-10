using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    public class ComisionesREST : IComisionesREST
    {
        private ComisionDAO dao = new ComisionDAO();

        public Comision CrearComision(Comision comisionACrear)
        {
            /*if ("1".Equals(comisionACrear.Numero))
            {
                throw new WebFaultException<string>(
                    "Comisión imposible", HttpStatusCode.HttpVersionNotSupported);
            }
            return dao.Crear(comisionACrear);*/
            return null;
        }

        public Comision ObtenerComision(string numero)
        {
            //return dao.Obtener(Convert.ToInt32(numero));
            return dao.Obtener(numero);
        }

        public Comision ModificarComision(Comision comisionAModificar)
        {
            return dao.Modificar(comisionAModificar);
        }

        public void EliminarComision(string numero)
        {
            dao.Eliminar(numero);
        }

        public List<Comision> ListarComisiones()
        {
            return dao.ListarTodos();
        }
    }
}

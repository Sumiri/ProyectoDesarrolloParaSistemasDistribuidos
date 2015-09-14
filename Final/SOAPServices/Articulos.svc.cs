using SOAPServices.Dominio;
using SOAPServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    public class Articulos : IArticulos
    {
        private ArticuloDAO articuloDAO = null;
        private ArticuloDAO ArticuloDAO
        {
            get
            {
                if (articuloDAO == null)
                    articuloDAO = new ArticuloDAO();
                return articuloDAO;
            }

        }


        public Articulo CrearArticulo(string descripcion)
        {
            Articulo articuloACrear = new Articulo()
            {
                Descripcion = descripcion
            };
            return ArticuloDAO.Crear(articuloACrear);

        }

        public Articulo ObtenerArticulo(int codigo)
        {
            return ArticuloDAO.Obtener(codigo);
        }

        public Articulo ModificarArticulo(int codigo, string descripcion)
        {
            Articulo articuloAModificar = new Articulo()
            {
                Descripcion = descripcion
            };
            return ArticuloDAO.Modificar(articuloAModificar);
        }

        public void EliminarArticulo(int codigo)
        {
            Articulo articuloExistente = ArticuloDAO.Obtener(codigo);
            ArticuloDAO.Eliminar(articuloExistente);
        }

        public List<Articulo> ListarArticulos()
        {
            return ArticuloDAO.ListarTodos().ToList();
        }
    }
}

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
    public class Stocks : IStocks
    {
        private StockDAO stockDAO = null;
        private StockDAO StockDAO
        {
            get
            {
                if (stockDAO == null)
                    stockDAO = new StockDAO();
                return stockDAO;
            }
        }
        
        public Stock ObtenerStock(int codigo)
        {
            return StockDAO.Obtener(codigo);
        }

        public Stock ModificarStock(int codigo, int nuevoStock)
        {
            Stock stockAModificar = new Stock()
            {
                Codigo = codigo,
                StockActual = nuevoStock
            };
            return StockDAO.Modificar(stockAModificar);
        }
    }
}

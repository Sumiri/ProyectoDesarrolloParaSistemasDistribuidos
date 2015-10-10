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
    public class PedidoDetalles : IPedidoDetalles
    {
        private PedidoDetalleDAO pedidoDetalleDAO = null;
        private PedidoDetalleDAO PedidoDetalleDAO
        {
            get
            {
                if (pedidoDetalleDAO == null)
                    pedidoDetalleDAO = new PedidoDetalleDAO();
                return pedidoDetalleDAO;
            }
        }

        public PedidoDetalle CrearPedidoDetalle(int codCompania, int codSucursalCia, int ano, int numeroPedido, int numeroItem, int codItemArticulo, int unidadesPedidas, int unidadesComprometidas, double importePrecioUnitarioSIGV, double importePrecioUnitarioCIGV, double importeSubtotalBruto, double porcentajeDescuento, double importeSubtotalDescuento, double importeSubtotalNeto, int codEstadoAtencion, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate)
        {
            PedidoDetalle pedidoDetalleACrear = new PedidoDetalle()
            {
                CodCompania = codCompania,
                CodSucursalCia = codSucursalCia,
                Ano = ano,
                NumeroPedido = numeroPedido,
                NumeroItem = numeroItem,
                CodItemArticulo = codItemArticulo,
                UnidadesPedidas = unidadesPedidas,
                UnidadesComprometidas = unidadesComprometidas,
                ImportePrecioUnitarioSIGV = importePrecioUnitarioSIGV,
                ImportePrecioUnitarioCIGV = importePrecioUnitarioCIGV,
                ImporteSubtotalBruto = importeSubtotalBruto,
                PorcentajeDescuento = porcentajeDescuento,
                ImporteSubtotalDescuento = importeSubtotalDescuento,
                ImporteSubtotalNeto = importeSubtotalNeto,
                CodEstadoAtencion = codEstadoAtencion,
                CodEstadoRegistro = codEstadoRegistro,
                CodUsuarioCreador = codUsuarioCreador,
                FecCreacion = fecCreacion,
                CodUsuarioUpdate = codUsuarioUpdate,
                FecUpdate = fecUpdate
            };
            return PedidoDetalleDAO.Crear(pedidoDetalleACrear);
        }

        public PedidoDetalle ObtenerPedidoDetalle(int numeroItem)
        {
            return PedidoDetalleDAO.Obtener(numeroItem);
        }

        public PedidoDetalle ModificarPedidoDetalle(int numeroItem, int codCompania, int codSucursalCia, int ano, int numeroPedido, int codItemArticulo, int unidadesPedidas, int unidadesComprometidas, double importePrecioUnitarioSIGV, double importePrecioUnitarioCIGV, double importeSubtotalBruto, double porcentajeDescuento, double importeSubtotalDescuento, double importeSubtotalNeto, int codEstadoAtencion, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate)
        {
            PedidoDetalle pedidoDetalleAModificar = new PedidoDetalle()
            {
                NumeroItem = numeroItem,
                CodCompania = codCompania,
                CodSucursalCia = codSucursalCia,
                Ano = ano,
                NumeroPedido = numeroPedido,
                CodItemArticulo = codItemArticulo,
                UnidadesPedidas = unidadesPedidas,
                UnidadesComprometidas = unidadesComprometidas,
                ImportePrecioUnitarioSIGV = importePrecioUnitarioSIGV,
                ImportePrecioUnitarioCIGV = importePrecioUnitarioCIGV,
                ImporteSubtotalBruto = importeSubtotalBruto,
                PorcentajeDescuento = porcentajeDescuento,
                ImporteSubtotalDescuento = importeSubtotalDescuento,
                ImporteSubtotalNeto = importeSubtotalNeto,
                CodEstadoAtencion = codEstadoAtencion,
                CodEstadoRegistro = codEstadoRegistro,
                CodUsuarioCreador = codUsuarioCreador,
                FecCreacion = fecCreacion,
                CodUsuarioUpdate = codUsuarioUpdate,
                FecUpdate = fecUpdate
            };
            return PedidoDetalleDAO.Modificar(pedidoDetalleAModificar);
        }    

        public void EliminarPedidoDetalle(int numeroItem)
        {
            PedidoDetalle pedidoDetalleExistente = PedidoDetalleDAO.Obtener(numeroItem);
            PedidoDetalleDAO.Eliminar(pedidoDetalleExistente);
        }

        public List<PedidoDetalle> ListarPedidoDetalle()
        {
            return PedidoDetalleDAO.ListarTodos().ToList();
        }
    }
}

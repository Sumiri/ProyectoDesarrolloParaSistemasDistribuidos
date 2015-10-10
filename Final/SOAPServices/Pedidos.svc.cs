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
     public class Pedidos : IPedidos
    {
        private PedidoDAO pedidoDAO = null;
        private PedidoDetalleDAO pedidoDetalleDAO = null;

        private PedidoDAO PedidoDAO
        {
            get
            {
                if (pedidoDAO == null)
                    pedidoDAO = new PedidoDAO();
                return pedidoDAO;
            }
        }
        private PedidoDetalleDAO PedidoDetalleDAO
        {
            get
            {
                if (pedidoDetalleDAO == null)
                    pedidoDetalleDAO = new PedidoDetalleDAO();
                return pedidoDetalleDAO;
            }
        }

        public Pedido CrearPedido(int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate)
        {
            Pedido pedidoACrear = new Pedido()
            {
                CodCompania = codCompania,
                CodSucursalCia = codSucursalCia,
                Ano = ano,
                FecPedido = fecPedido,
                CodCliente = codCliente,
                CodSucursal = codSucursal,
                CodUsuarioVendedor = codUsuarioVendedor,
                CodDocumentoFacturacion = codDocumentoFacturacion,
                NumeroOrdenCompra = numeroOrdenCompra,
                CodMoneda = codMoneda,
                ImporteTotalBruto = importeTotalBruto,
                ImporteTotalDescuento = importeTotalDescuento,
                PorcentajeIGV = porcentajeIGV,
                ImporteTotalIGV = importeTotalIGV,
                ImporteTotalNeto = importeTotalNeto,
                CodEstadoAtencion = codEstadoAtencion,
                CodAlmacen = codAlmacen,
                CodEstadoRegistro = codEstadoRegistro,
                CodUsuarioCreador = codUsuarioCreador,
                FecCreacion = fecCreacion,
                CodUsuarioUpdate = codUsuarioUpdate,
                FecUpdate = fecUpdate,
            };
            return PedidoDAO.Crear(pedidoACrear);
        }

        public Pedido GenerarPedido(int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate, List<PedidoDetalle> detalle)
        {
            Pedido pedidoACrear = new Pedido()
            {
                CodCompania = codCompania,
                CodSucursalCia = codSucursalCia,
                Ano = ano,
                FecPedido = fecPedido,
                CodCliente = codCliente,
                CodSucursal = codSucursal,
                CodUsuarioVendedor = codUsuarioVendedor,
                CodDocumentoFacturacion = codDocumentoFacturacion,
                NumeroOrdenCompra = numeroOrdenCompra,
                CodMoneda = codMoneda,
                ImporteTotalBruto = importeTotalBruto,
                ImporteTotalDescuento = importeTotalDescuento,
                PorcentajeIGV = porcentajeIGV,
                ImporteTotalIGV = importeTotalIGV,
                ImporteTotalNeto = importeTotalNeto,
                CodEstadoAtencion = codEstadoAtencion,
                CodAlmacen = codAlmacen,
                CodEstadoRegistro = codEstadoRegistro,
                CodUsuarioCreador = codUsuarioCreador,
                FecCreacion = fecCreacion,
                CodUsuarioUpdate = codUsuarioUpdate,
                FecUpdate = fecUpdate
            };
            PedidoDAO.Crear(pedidoACrear);

            foreach (PedidoDetalle pedidoDetalleCrear in detalle)
            {
                PedidoDetalleDAO.Crear(pedidoDetalleCrear);
            }
            return pedidoACrear;
            //PedidoDetalle pedidoDetalleACrear = new PedidoDetalle()
            //{
            //    CodCompania = codCompania,
            //    CodSucursalCia = codSucursalCia,
            //    Ano = ano,
            //    NumeroPedido = numeroPedido,
            //    NumeroItem = numeroItem,
            //    CodItemArticulo = codItemArticulo,
            //    UnidadesPedidas = unidadesPedidas,
            //    UnidadesComprometidas = unidadesComprometidas,
            //    ImportePrecioUnitarioSIGV = importePrecioUnitarioSIGV,
            //    ImportePrecioUnitarioCIGV = importePrecioUnitarioCIGV,
            //    ImporteSubtotalBruto = importeSubtotalBruto,
            //    PorcentajeDescuento = porcentajeDescuento,
            //    ImporteSubtotalDescuento = importeSubtotalDescuento,
            //    ImporteSubtotalNeto = importeSubtotalNeto,
            //    CodEstadoAtencion = codEstadoAtencion,
            //    CodEstadoRegistro = codEstadoRegistro,
            //    CodUsuarioCreador = codUsuarioCreador,
            //    FecCreacion = fecCreacion,
            //    CodUsuarioUpdate = codUsuarioUpdate,
            //    FecUpdate = fecUpdate
            //};
            //return PedidoDetalleDAO.Crear(pedidoDetalleACrear);
        }
        public Pedido ObtenerPedido(int numeroPedido)
        {
            return PedidoDAO.Obtener(numeroPedido);
        }

        public Pedido ModificarPedido(int numeroPedido, int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate)
        {
            Pedido pedidoAModificar = new Pedido()
            {
                NumeroPedido = numeroPedido,
                CodCompania = codCompania,
                CodSucursalCia = codSucursalCia,
                Ano = ano,
                FecPedido = fecPedido,
                CodCliente = codCliente,
                CodSucursal = codSucursal,
                CodUsuarioVendedor = codUsuarioVendedor,
                CodDocumentoFacturacion = codDocumentoFacturacion,
                NumeroOrdenCompra = numeroOrdenCompra,
                CodMoneda = codMoneda,
                ImporteTotalBruto = importeTotalBruto,
                ImporteTotalDescuento = importeTotalDescuento,
                PorcentajeIGV = porcentajeIGV,
                ImporteTotalIGV = importeTotalIGV,
                ImporteTotalNeto = importeTotalNeto,
                CodEstadoAtencion = codEstadoAtencion,
                CodAlmacen = codAlmacen,
                CodEstadoRegistro = codEstadoRegistro,
                CodUsuarioCreador = codUsuarioCreador,
                FecCreacion = fecCreacion,
                CodUsuarioUpdate = codUsuarioUpdate,
                FecUpdate = fecUpdate
            };
            return PedidoDAO.Modificar(pedidoAModificar);
        }

        public void EliminarPedido(int numeroPedido)
        {
            Pedido pedidoExistente = PedidoDAO.Obtener(numeroPedido);
            PedidoDAO.Eliminar(pedidoExistente);
        }

        public List<Pedido> ListarPedidos()
        {
            return PedidoDAO.ListarTodos().ToList();
        }
    }
}

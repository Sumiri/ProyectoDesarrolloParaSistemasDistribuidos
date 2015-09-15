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
        private PedidoDAO PedidoDAO
        {
            get
            {
                if (pedidoDAO == null)
                    pedidoDAO = new PedidoDAO();
                return pedidoDAO;
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
                FecUpdate = fecUpdate
            };
            return PedidoDAO.Crear(pedidoACrear);
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

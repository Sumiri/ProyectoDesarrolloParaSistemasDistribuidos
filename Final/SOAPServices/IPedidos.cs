using SOAPServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAPServices
{
    [ServiceContract]
    public interface IPedidos
    {
        [OperationContract]
        Pedido CrearPedido(int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate);
        [OperationContract]
        Pedido GenerarPedido(int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate, List<PedidoDetalle> detalle);
        [OperationContract]
        Pedido ObtenerPedido(int numeroPedido);
        [OperationContract]
        Pedido ModificarPedido(int numeroPedido, int codCompania, int codSucursalCia, int ano, DateTime fecPedido, int codCliente, int codSucursal, string codUsuarioVendedor, int codDocumentoFacturacion, string numeroOrdenCompra, int codMoneda, double importeTotalBruto, double importeTotalDescuento, double porcentajeIGV, double importeTotalIGV, double importeTotalNeto, int codEstadoAtencion, int codAlmacen, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate);
        [OperationContract]
        void EliminarPedido(int numeroPedido);
        [OperationContract]
        List<Pedido> ListarPedidos();
    }
}

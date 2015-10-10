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
    public interface IPedidoDetalles
    {
        [OperationContract]
        PedidoDetalle CrearPedidoDetalle(int codCompania, int codSucursalCia, int ano, int numeroPedido, int numeroItem, int codItemArticulo, int unidadesPedidas, int unidadesComprometidas, double importePrecioUnitarioSIGV, double importePrecioUnitarioCIGV, double importeSubtotalBruto, double porcentajeDescuento, double importeSubtotalDescuento, double importeSubtotalNeto, int codEstadoAtencion, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate);
        [OperationContract]
        PedidoDetalle ObtenerPedidoDetalle(int numeroItem);
        [OperationContract]
        PedidoDetalle ModificarPedidoDetalle(int numeroItem, int codCompania, int codSucursalCia, int ano, int numeroPedido, int codItemArticulo, int unidadesPedidas, int unidadesComprometidas, double importePrecioUnitarioSIGV, double importePrecioUnitarioCIGV, double importeSubtotalBruto, double porcentajeDescuento, double importeSubtotalDescuento, double importeSubtotalNeto, int codEstadoAtencion, int codEstadoRegistro, string codUsuarioCreador, DateTime fecCreacion, string codUsuarioUpdate, DateTime fecUpdate);
        [OperationContract]
        void EliminarPedidoDetalle(int numeroItem);
        [OperationContract]
        List<PedidoDetalle> ListarPedidoDetalle();
    }
}

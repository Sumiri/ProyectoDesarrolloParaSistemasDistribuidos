﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosWin.PedidosWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PedidosWS.IPedidos")]
    public interface IPedidos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/CrearPedido", ReplyAction="http://tempuri.org/IPedidos/CrearPedidoResponse")]
        SOAPServices.Dominio.Pedido CrearPedido(
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/CrearPedido", ReplyAction="http://tempuri.org/IPedidos/CrearPedidoResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> CrearPedidoAsync(
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ObtenerPedido", ReplyAction="http://tempuri.org/IPedidos/ObtenerPedidoResponse")]
        SOAPServices.Dominio.Pedido ObtenerPedido(int numeroPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ObtenerPedido", ReplyAction="http://tempuri.org/IPedidos/ObtenerPedidoResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> ObtenerPedidoAsync(int numeroPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ModificarPedido", ReplyAction="http://tempuri.org/IPedidos/ModificarPedidoResponse")]
        SOAPServices.Dominio.Pedido ModificarPedido(
                    int numeroPedido, 
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ModificarPedido", ReplyAction="http://tempuri.org/IPedidos/ModificarPedidoResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> ModificarPedidoAsync(
                    int numeroPedido, 
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/EliminarPedido", ReplyAction="http://tempuri.org/IPedidos/EliminarPedidoResponse")]
        void EliminarPedido(int numeroPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/EliminarPedido", ReplyAction="http://tempuri.org/IPedidos/EliminarPedidoResponse")]
        System.Threading.Tasks.Task EliminarPedidoAsync(int numeroPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ListarPedidos", ReplyAction="http://tempuri.org/IPedidos/ListarPedidosResponse")]
        SOAPServices.Dominio.Pedido[] ListarPedidos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPedidos/ListarPedidos", ReplyAction="http://tempuri.org/IPedidos/ListarPedidosResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido[]> ListarPedidosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPedidosChannel : PedidosWin.PedidosWS.IPedidos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PedidosClient : System.ServiceModel.ClientBase<PedidosWin.PedidosWS.IPedidos>, PedidosWin.PedidosWS.IPedidos {
        
        public PedidosClient() {
        }
        
        public PedidosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PedidosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PedidosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.Dominio.Pedido CrearPedido(
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate) {
            return base.Channel.CrearPedido(codCompania, codSucursalCia, ano, fecPedido, codCliente, codSucursal, codUsuarioVendedor, codDocumentoFacturacion, numeroOrdenCompra, codMoneda, importeTotalBruto, importeTotalDescuento, porcentajeIGV, importeTotalIGV, importeTotalNeto, codEstadoAtencion, codAlmacen, codEstadoRegistro, codUsuarioCreador, fecCreacion, codUsuarioUpdate, fecUpdate);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> CrearPedidoAsync(
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate) {
            return base.Channel.CrearPedidoAsync(codCompania, codSucursalCia, ano, fecPedido, codCliente, codSucursal, codUsuarioVendedor, codDocumentoFacturacion, numeroOrdenCompra, codMoneda, importeTotalBruto, importeTotalDescuento, porcentajeIGV, importeTotalIGV, importeTotalNeto, codEstadoAtencion, codAlmacen, codEstadoRegistro, codUsuarioCreador, fecCreacion, codUsuarioUpdate, fecUpdate);
        }
        
        public SOAPServices.Dominio.Pedido ObtenerPedido(int numeroPedido) {
            return base.Channel.ObtenerPedido(numeroPedido);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> ObtenerPedidoAsync(int numeroPedido) {
            return base.Channel.ObtenerPedidoAsync(numeroPedido);
        }
        
        public SOAPServices.Dominio.Pedido ModificarPedido(
                    int numeroPedido, 
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate) {
            return base.Channel.ModificarPedido(numeroPedido, codCompania, codSucursalCia, ano, fecPedido, codCliente, codSucursal, codUsuarioVendedor, codDocumentoFacturacion, numeroOrdenCompra, codMoneda, importeTotalBruto, importeTotalDescuento, porcentajeIGV, importeTotalIGV, importeTotalNeto, codEstadoAtencion, codAlmacen, codEstadoRegistro, codUsuarioCreador, fecCreacion, codUsuarioUpdate, fecUpdate);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido> ModificarPedidoAsync(
                    int numeroPedido, 
                    int codCompania, 
                    int codSucursalCia, 
                    int ano, 
                    System.DateTime fecPedido, 
                    int codCliente, 
                    int codSucursal, 
                    string codUsuarioVendedor, 
                    int codDocumentoFacturacion, 
                    string numeroOrdenCompra, 
                    int codMoneda, 
                    double importeTotalBruto, 
                    double importeTotalDescuento, 
                    double porcentajeIGV, 
                    double importeTotalIGV, 
                    double importeTotalNeto, 
                    int codEstadoAtencion, 
                    int codAlmacen, 
                    int codEstadoRegistro, 
                    string codUsuarioCreador, 
                    System.DateTime fecCreacion, 
                    string codUsuarioUpdate, 
                    System.DateTime fecUpdate) {
            return base.Channel.ModificarPedidoAsync(numeroPedido, codCompania, codSucursalCia, ano, fecPedido, codCliente, codSucursal, codUsuarioVendedor, codDocumentoFacturacion, numeroOrdenCompra, codMoneda, importeTotalBruto, importeTotalDescuento, porcentajeIGV, importeTotalIGV, importeTotalNeto, codEstadoAtencion, codAlmacen, codEstadoRegistro, codUsuarioCreador, fecCreacion, codUsuarioUpdate, fecUpdate);
        }
        
        public void EliminarPedido(int numeroPedido) {
            base.Channel.EliminarPedido(numeroPedido);
        }
        
        public System.Threading.Tasks.Task EliminarPedidoAsync(int numeroPedido) {
            return base.Channel.EliminarPedidoAsync(numeroPedido);
        }
        
        public SOAPServices.Dominio.Pedido[] ListarPedidos() {
            return base.Channel.ListarPedidos();
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Pedido[]> ListarPedidosAsync() {
            return base.Channel.ListarPedidosAsync();
        }
    }
}
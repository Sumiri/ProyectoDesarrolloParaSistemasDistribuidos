﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosWin.ClientesServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientesServiceReference.IClientes")]
    public interface IClientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCliente", ReplyAction="http://tempuri.org/IClientes/CrearClienteResponse")]
        SOAPServices.Dominio.Cliente CrearCliente(string razonsocial, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCliente", ReplyAction="http://tempuri.org/IClientes/CrearClienteResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> CrearClienteAsync(string razonsocial, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObtenerCliente", ReplyAction="http://tempuri.org/IClientes/ObtenerClienteResponse")]
        SOAPServices.Dominio.Cliente ObtenerCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObtenerCliente", ReplyAction="http://tempuri.org/IClientes/ObtenerClienteResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> ObtenerClienteAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ModificarCliente", ReplyAction="http://tempuri.org/IClientes/ModificarClienteResponse")]
        SOAPServices.Dominio.Cliente ModificarCliente(int codigo, string razonsocial, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ModificarCliente", ReplyAction="http://tempuri.org/IClientes/ModificarClienteResponse")]
        System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> ModificarClienteAsync(int codigo, string razonsocial, string correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/EliminarCliente", ReplyAction="http://tempuri.org/IClientes/EliminarClienteResponse")]
        void EliminarCliente(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/EliminarCliente", ReplyAction="http://tempuri.org/IClientes/EliminarClienteResponse")]
        System.Threading.Tasks.Task EliminarClienteAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ListarClientes", ReplyAction="http://tempuri.org/IClientes/ListarClientesResponse")]
        System.Collections.Generic.List<SOAPServices.Dominio.Cliente> ListarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ListarClientes", ReplyAction="http://tempuri.org/IClientes/ListarClientesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SOAPServices.Dominio.Cliente>> ListarClientesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientesChannel : PedidosWin.ClientesServiceReference.IClientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesClient : System.ServiceModel.ClientBase<PedidosWin.ClientesServiceReference.IClientes>, PedidosWin.ClientesServiceReference.IClientes {
        
        public ClientesClient() {
        }
        
        public ClientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.Dominio.Cliente CrearCliente(string razonsocial, string correo) {
            return base.Channel.CrearCliente(razonsocial, correo);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> CrearClienteAsync(string razonsocial, string correo) {
            return base.Channel.CrearClienteAsync(razonsocial, correo);
        }
        
        public SOAPServices.Dominio.Cliente ObtenerCliente(int codigo) {
            return base.Channel.ObtenerCliente(codigo);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> ObtenerClienteAsync(int codigo) {
            return base.Channel.ObtenerClienteAsync(codigo);
        }
        
        public SOAPServices.Dominio.Cliente ModificarCliente(int codigo, string razonsocial, string correo) {
            return base.Channel.ModificarCliente(codigo, razonsocial, correo);
        }
        
        public System.Threading.Tasks.Task<SOAPServices.Dominio.Cliente> ModificarClienteAsync(int codigo, string razonsocial, string correo) {
            return base.Channel.ModificarClienteAsync(codigo, razonsocial, correo);
        }
        
        public void EliminarCliente(int codigo) {
            base.Channel.EliminarCliente(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarClienteAsync(int codigo) {
            return base.Channel.EliminarClienteAsync(codigo);
        }
        
        public System.Collections.Generic.List<SOAPServices.Dominio.Cliente> ListarClientes() {
            return base.Channel.ListarClientes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SOAPServices.Dominio.Cliente>> ListarClientesAsync() {
            return base.Channel.ListarClientesAsync();
        }
    }
}

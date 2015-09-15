﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosWin.ArticulosServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Articulo", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Articulo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ArticulosServiceReference.IArticulos")]
    public interface IArticulos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/CrearArticulo", ReplyAction="http://tempuri.org/IArticulos/CrearArticuloResponse")]
        PedidosWin.ArticulosServiceReference.Articulo CrearArticulo(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/CrearArticulo", ReplyAction="http://tempuri.org/IArticulos/CrearArticuloResponse")]
        System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> CrearArticuloAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ObtenerArticulo", ReplyAction="http://tempuri.org/IArticulos/ObtenerArticuloResponse")]
        PedidosWin.ArticulosServiceReference.Articulo ObtenerArticulo(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ObtenerArticulo", ReplyAction="http://tempuri.org/IArticulos/ObtenerArticuloResponse")]
        System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> ObtenerArticuloAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ModificarArticulo", ReplyAction="http://tempuri.org/IArticulos/ModificarArticuloResponse")]
        PedidosWin.ArticulosServiceReference.Articulo ModificarArticulo(int codigo, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ModificarArticulo", ReplyAction="http://tempuri.org/IArticulos/ModificarArticuloResponse")]
        System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> ModificarArticuloAsync(int codigo, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/EliminarArticulo", ReplyAction="http://tempuri.org/IArticulos/EliminarArticuloResponse")]
        void EliminarArticulo(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/EliminarArticulo", ReplyAction="http://tempuri.org/IArticulos/EliminarArticuloResponse")]
        System.Threading.Tasks.Task EliminarArticuloAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ListarArticulos", ReplyAction="http://tempuri.org/IArticulos/ListarArticulosResponse")]
        System.Collections.Generic.List<PedidosWin.ArticulosServiceReference.Articulo> ListarArticulos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArticulos/ListarArticulos", ReplyAction="http://tempuri.org/IArticulos/ListarArticulosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<PedidosWin.ArticulosServiceReference.Articulo>> ListarArticulosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IArticulosChannel : PedidosWin.ArticulosServiceReference.IArticulos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ArticulosClient : System.ServiceModel.ClientBase<PedidosWin.ArticulosServiceReference.IArticulos>, PedidosWin.ArticulosServiceReference.IArticulos {
        
        public ArticulosClient() {
        }
        
        public ArticulosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ArticulosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArticulosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArticulosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PedidosWin.ArticulosServiceReference.Articulo CrearArticulo(string descripcion) {
            return base.Channel.CrearArticulo(descripcion);
        }
        
        public System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> CrearArticuloAsync(string descripcion) {
            return base.Channel.CrearArticuloAsync(descripcion);
        }
        
        public PedidosWin.ArticulosServiceReference.Articulo ObtenerArticulo(int codigo) {
            return base.Channel.ObtenerArticulo(codigo);
        }
        
        public System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> ObtenerArticuloAsync(int codigo) {
            return base.Channel.ObtenerArticuloAsync(codigo);
        }
        
        public PedidosWin.ArticulosServiceReference.Articulo ModificarArticulo(int codigo, string descripcion) {
            return base.Channel.ModificarArticulo(codigo, descripcion);
        }
        
        public System.Threading.Tasks.Task<PedidosWin.ArticulosServiceReference.Articulo> ModificarArticuloAsync(int codigo, string descripcion) {
            return base.Channel.ModificarArticuloAsync(codigo, descripcion);
        }
        
        public void EliminarArticulo(int codigo) {
            base.Channel.EliminarArticulo(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarArticuloAsync(int codigo) {
            return base.Channel.EliminarArticuloAsync(codigo);
        }
        
        public System.Collections.Generic.List<PedidosWin.ArticulosServiceReference.Articulo> ListarArticulos() {
            return base.Channel.ListarArticulos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<PedidosWin.ArticulosServiceReference.Articulo>> ListarArticulosAsync() {
            return base.Channel.ListarArticulosAsync();
        }
    }
}
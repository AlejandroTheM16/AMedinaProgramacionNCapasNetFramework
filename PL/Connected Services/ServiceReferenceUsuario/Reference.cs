﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.ServiceReferenceUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.IUsuario")]
    public interface IUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/DoWork", ReplyAction="http://tempuri.org/IUsuario/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/DoWork", ReplyAction="http://tempuri.org/IUsuario/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Add", ReplyAction="http://tempuri.org/IUsuario/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SL_WCF.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        SL_WCF.Result Add(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Add", ReplyAction="http://tempuri.org/IUsuario/AddResponse")]
        System.Threading.Tasks.Task<SL_WCF.Result> AddAsync(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Update", ReplyAction="http://tempuri.org/IUsuario/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SL_WCF.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        SL_WCF.Result Update(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Update", ReplyAction="http://tempuri.org/IUsuario/UpdateResponse")]
        System.Threading.Tasks.Task<SL_WCF.Result> UpdateAsync(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Delete", ReplyAction="http://tempuri.org/IUsuario/DeleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        SL_WCF.Result Delete(int Idusuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/Delete", ReplyAction="http://tempuri.org/IUsuario/DeleteResponse")]
        System.Threading.Tasks.Task<SL_WCF.Result> DeleteAsync(int Idusuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetAll", ReplyAction="http://tempuri.org/IUsuario/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        SL_WCF.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetAll", ReplyAction="http://tempuri.org/IUsuario/GetAllResponse")]
        System.Threading.Tasks.Task<SL_WCF.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetById", ReplyAction="http://tempuri.org/IUsuario/GetByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Usuario))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        SL_WCF.Result GetById(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuario/GetById", ReplyAction="http://tempuri.org/IUsuario/GetByIdResponse")]
        System.Threading.Tasks.Task<SL_WCF.Result> GetByIdAsync(int IdUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioChannel : PL.ServiceReferenceUsuario.IUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioClient : System.ServiceModel.ClientBase<PL.ServiceReferenceUsuario.IUsuario>, PL.ServiceReferenceUsuario.IUsuario {
        
        public UsuarioClient() {
        }
        
        public UsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public SL_WCF.Result Add(ML.Usuario usuario) {
            return base.Channel.Add(usuario);
        }
        
        public System.Threading.Tasks.Task<SL_WCF.Result> AddAsync(ML.Usuario usuario) {
            return base.Channel.AddAsync(usuario);
        }
        
        public SL_WCF.Result Update(ML.Usuario usuario) {
            return base.Channel.Update(usuario);
        }
        
        public System.Threading.Tasks.Task<SL_WCF.Result> UpdateAsync(ML.Usuario usuario) {
            return base.Channel.UpdateAsync(usuario);
        }
        
        public SL_WCF.Result Delete(int Idusuario) {
            return base.Channel.Delete(Idusuario);
        }
        
        public System.Threading.Tasks.Task<SL_WCF.Result> DeleteAsync(int Idusuario) {
            return base.Channel.DeleteAsync(Idusuario);
        }
        
        public SL_WCF.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<SL_WCF.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public SL_WCF.Result GetById(int IdUsuario) {
            return base.Channel.GetById(IdUsuario);
        }
        
        public System.Threading.Tasks.Task<SL_WCF.Result> GetByIdAsync(int IdUsuario) {
            return base.Channel.GetByIdAsync(IdUsuario);
        }
    }
}
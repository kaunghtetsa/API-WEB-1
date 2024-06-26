﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2C2PClientWebApp.TCTPService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TCTPService.ITCTPService")]
    public interface ITCTPService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCTPService/InsertTransaction", ReplyAction="http://tempuri.org/ITCTPService/InsertTransactionResponse")]
        string InsertTransaction(string AuthenticationKey, string UserAgentName, string IPAddress, string FileType, string RequestBody);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCTPService/InsertTransaction", ReplyAction="http://tempuri.org/ITCTPService/InsertTransactionResponse")]
        System.Threading.Tasks.Task<string> InsertTransactionAsync(string AuthenticationKey, string UserAgentName, string IPAddress, string FileType, string RequestBody);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCTPService/GetTransactions", ReplyAction="http://tempuri.org/ITCTPService/GetTransactionsResponse")]
        string GetTransactions(string AuthenticationKey, string ByCurrency, string DateTimeFrom, string DateTimeTo, string ByStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITCTPService/GetTransactions", ReplyAction="http://tempuri.org/ITCTPService/GetTransactionsResponse")]
        System.Threading.Tasks.Task<string> GetTransactionsAsync(string AuthenticationKey, string ByCurrency, string DateTimeFrom, string DateTimeTo, string ByStatus);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITCTPServiceChannel : _2C2PClientWebApp.TCTPService.ITCTPService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TCTPServiceClient : System.ServiceModel.ClientBase<_2C2PClientWebApp.TCTPService.ITCTPService>, _2C2PClientWebApp.TCTPService.ITCTPService {
        
        public TCTPServiceClient() {
        }
        
        public TCTPServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TCTPServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCTPServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TCTPServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertTransaction(string AuthenticationKey, string UserAgentName, string IPAddress, string FileType, string RequestBody) {
            return base.Channel.InsertTransaction(AuthenticationKey, UserAgentName, IPAddress, FileType, RequestBody);
        }
        
        public System.Threading.Tasks.Task<string> InsertTransactionAsync(string AuthenticationKey, string UserAgentName, string IPAddress, string FileType, string RequestBody) {
            return base.Channel.InsertTransactionAsync(AuthenticationKey, UserAgentName, IPAddress, FileType, RequestBody);
        }
        
        public string GetTransactions(string AuthenticationKey, string ByCurrency, string DateTimeFrom, string DateTimeTo, string ByStatus) {
            return base.Channel.GetTransactions(AuthenticationKey, ByCurrency, DateTimeFrom, DateTimeTo, ByStatus);
        }
        
        public System.Threading.Tasks.Task<string> GetTransactionsAsync(string AuthenticationKey, string ByCurrency, string DateTimeFrom, string DateTimeTo, string ByStatus) {
            return base.Channel.GetTransactionsAsync(AuthenticationKey, ByCurrency, DateTimeFrom, DateTimeTo, ByStatus);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenericCallExecute.GenericCallP0 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gtx.nu/Services/Automation/V2/ExecuteP0", ConfigurationName="GenericCallP0.ShipmentEventPollSoap")]
    internal interface ShipmentEventPollSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gtx.nu/Services/Automation/V2/ExecuteP0/Execute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Execute();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gtx.nu/Services/Automation/V2/ExecuteP0/Ping", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Ping();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface ShipmentEventPollSoapChannel : GenericCallExecute.GenericCallP0.ShipmentEventPollSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class ShipmentEventPollSoapClient : System.ServiceModel.ClientBase<GenericCallExecute.GenericCallP0.ShipmentEventPollSoap>, GenericCallExecute.GenericCallP0.ShipmentEventPollSoap {
        
        public ShipmentEventPollSoapClient() {
        }
        
        public ShipmentEventPollSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShipmentEventPollSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentEventPollSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentEventPollSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Execute() {
            return base.Channel.Execute();
        }
        
        public string Ping() {
            return base.Channel.Ping();
        }
    }
}
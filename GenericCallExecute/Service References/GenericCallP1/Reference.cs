﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenericCallExecute.GenericCallP1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gtx.nu/Services/Automation/V2/ExecuteP1", ConfigurationName="GenericCallP1.ShipmentEventPollSpecificSoap")]
    public interface ShipmentEventPollSpecificSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gtx.nu/Services/Automation/V2/ExecuteP1/Execute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Execute(string waybillnumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://gtx.nu/Services/Automation/V2/ExecuteP1/Ping", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Ping();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ShipmentEventPollSpecificSoapChannel : GenericCallExecute.GenericCallP1.ShipmentEventPollSpecificSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShipmentEventPollSpecificSoapClient : System.ServiceModel.ClientBase<GenericCallExecute.GenericCallP1.ShipmentEventPollSpecificSoap>, GenericCallExecute.GenericCallP1.ShipmentEventPollSpecificSoap {
        
        public ShipmentEventPollSpecificSoapClient() {
        }
        
        public ShipmentEventPollSpecificSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShipmentEventPollSpecificSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentEventPollSpecificSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShipmentEventPollSpecificSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Execute(string waybillnumber) {
            return base.Channel.Execute(waybillnumber);
        }
        
        public string Ping() {
            return base.Channel.Ping();
        }
    }
}

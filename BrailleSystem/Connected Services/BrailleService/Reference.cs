﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrailleSystem.BrailleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BrailleService.BrailleServiceSoap")]
    public interface BrailleServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateRectangleArea", ReplyAction="*")]
        double CalculateRectangleArea(double hight, double width);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateRectangleArea", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateRectangleAreaAsync(double hight, double width);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateCircleArea", ReplyAction="*")]
        double CalculateCircleArea(double radius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateCircleArea", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateCircleAreaAsync(double radius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateTriangleArea", ReplyAction="*")]
        double CalculateTriangleArea(double baseLength, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateTriangleArea", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateTriangleAreaAsync(double baseLength, double height);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BrailleServiceSoapChannel : BrailleSystem.BrailleService.BrailleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrailleServiceSoapClient : System.ServiceModel.ClientBase<BrailleSystem.BrailleService.BrailleServiceSoap>, BrailleSystem.BrailleService.BrailleServiceSoap {
        
        public BrailleServiceSoapClient() {
        }
        
        public BrailleServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrailleServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrailleServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrailleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalculateRectangleArea(double hight, double width) {
            return base.Channel.CalculateRectangleArea(hight, width);
        }
        
        public System.Threading.Tasks.Task<double> CalculateRectangleAreaAsync(double hight, double width) {
            return base.Channel.CalculateRectangleAreaAsync(hight, width);
        }
        
        public double CalculateCircleArea(double radius) {
            return base.Channel.CalculateCircleArea(radius);
        }
        
        public System.Threading.Tasks.Task<double> CalculateCircleAreaAsync(double radius) {
            return base.Channel.CalculateCircleAreaAsync(radius);
        }
        
        public double CalculateTriangleArea(double baseLength, double height) {
            return base.Channel.CalculateTriangleArea(baseLength, height);
        }
        
        public System.Threading.Tasks.Task<double> CalculateTriangleAreaAsync(double baseLength, double height) {
            return base.Channel.CalculateTriangleAreaAsync(baseLength, height);
        }
    }
}

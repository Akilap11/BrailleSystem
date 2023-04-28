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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
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
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        BrailleSystem.BrailleService.GetCalculationsResponse GetCalculations(BrailleSystem.BrailleService.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<BrailleSystem.BrailleService.GetCalculationsResponse> GetCalculationsAsync(BrailleSystem.BrailleService.GetCalculationsRequest request);
        
        // CODEGEN: Generating message contract since element name text from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToBraille", ReplyAction="*")]
        BrailleSystem.BrailleService.ConvertToBrailleResponse ConvertToBraille(BrailleSystem.BrailleService.ConvertToBrailleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToBraille", ReplyAction="*")]
        System.Threading.Tasks.Task<BrailleSystem.BrailleService.ConvertToBrailleResponse> ConvertToBrailleAsync(BrailleSystem.BrailleService.ConvertToBrailleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://tempuri.org/", Order=0)]
        public BrailleSystem.BrailleService.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(BrailleSystem.BrailleService.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public BrailleSystem.BrailleService.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(BrailleSystem.BrailleService.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BrailleSystem.BrailleService.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(BrailleSystem.BrailleService.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToBrailleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToBraille", Namespace="http://tempuri.org/", Order=0)]
        public BrailleSystem.BrailleService.ConvertToBrailleRequestBody Body;
        
        public ConvertToBrailleRequest() {
        }
        
        public ConvertToBrailleRequest(BrailleSystem.BrailleService.ConvertToBrailleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToBrailleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string text;
        
        public ConvertToBrailleRequestBody() {
        }
        
        public ConvertToBrailleRequestBody(string text) {
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToBrailleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToBrailleResponse", Namespace="http://tempuri.org/", Order=0)]
        public BrailleSystem.BrailleService.ConvertToBrailleResponseBody Body;
        
        public ConvertToBrailleResponse() {
        }
        
        public ConvertToBrailleResponse(BrailleSystem.BrailleService.ConvertToBrailleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToBrailleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConvertToBrailleResult;
        
        public ConvertToBrailleResponseBody() {
        }
        
        public ConvertToBrailleResponseBody(string ConvertToBrailleResult) {
            this.ConvertToBrailleResult = ConvertToBrailleResult;
        }
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BrailleSystem.BrailleService.GetCalculationsResponse BrailleSystem.BrailleService.BrailleServiceSoap.GetCalculations(BrailleSystem.BrailleService.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public BrailleSystem.BrailleService.ArrayOfString GetCalculations() {
            BrailleSystem.BrailleService.GetCalculationsRequest inValue = new BrailleSystem.BrailleService.GetCalculationsRequest();
            inValue.Body = new BrailleSystem.BrailleService.GetCalculationsRequestBody();
            BrailleSystem.BrailleService.GetCalculationsResponse retVal = ((BrailleSystem.BrailleService.BrailleServiceSoap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BrailleSystem.BrailleService.GetCalculationsResponse> BrailleSystem.BrailleService.BrailleServiceSoap.GetCalculationsAsync(BrailleSystem.BrailleService.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<BrailleSystem.BrailleService.GetCalculationsResponse> GetCalculationsAsync() {
            BrailleSystem.BrailleService.GetCalculationsRequest inValue = new BrailleSystem.BrailleService.GetCalculationsRequest();
            inValue.Body = new BrailleSystem.BrailleService.GetCalculationsRequestBody();
            return ((BrailleSystem.BrailleService.BrailleServiceSoap)(this)).GetCalculationsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BrailleSystem.BrailleService.ConvertToBrailleResponse BrailleSystem.BrailleService.BrailleServiceSoap.ConvertToBraille(BrailleSystem.BrailleService.ConvertToBrailleRequest request) {
            return base.Channel.ConvertToBraille(request);
        }
        
        public string ConvertToBraille(string text) {
            BrailleSystem.BrailleService.ConvertToBrailleRequest inValue = new BrailleSystem.BrailleService.ConvertToBrailleRequest();
            inValue.Body = new BrailleSystem.BrailleService.ConvertToBrailleRequestBody();
            inValue.Body.text = text;
            BrailleSystem.BrailleService.ConvertToBrailleResponse retVal = ((BrailleSystem.BrailleService.BrailleServiceSoap)(this)).ConvertToBraille(inValue);
            return retVal.Body.ConvertToBrailleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BrailleSystem.BrailleService.ConvertToBrailleResponse> BrailleSystem.BrailleService.BrailleServiceSoap.ConvertToBrailleAsync(BrailleSystem.BrailleService.ConvertToBrailleRequest request) {
            return base.Channel.ConvertToBrailleAsync(request);
        }
        
        public System.Threading.Tasks.Task<BrailleSystem.BrailleService.ConvertToBrailleResponse> ConvertToBrailleAsync(string text) {
            BrailleSystem.BrailleService.ConvertToBrailleRequest inValue = new BrailleSystem.BrailleService.ConvertToBrailleRequest();
            inValue.Body = new BrailleSystem.BrailleService.ConvertToBrailleRequestBody();
            inValue.Body.text = text;
            return ((BrailleSystem.BrailleService.BrailleServiceSoap)(this)).ConvertToBrailleAsync(inValue);
        }
    }
}

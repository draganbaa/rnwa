﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeDBWebServices.KlijentAplikacija4 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KlijentAplikacija4.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse HelloWorld(CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse> HelloWorldAsync(CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSquare", ReplyAction="*")]
        int GetSquare(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSquare", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetSquareAsync(int a);
        
        // CODEGEN: Generating message contract since element name GetInfoStudentResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInfoStudent", ReplyAction="*")]
        CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse GetInfoStudent(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInfoStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse> GetInfoStudentAsync(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInfoStudent", Namespace="http://tempuri.org/", Order=0)]
        public CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequestBody Body;
        
        public GetInfoStudentRequest() {
        }
        
        public GetInfoStudentRequest(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInfoStudentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetInfoStudentRequestBody() {
        }
        
        public GetInfoStudentRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInfoStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponseBody Body;
        
        public GetInfoStudentResponse() {
        }
        
        public GetInfoStudentResponse(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetInfoStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetInfoStudentResult;
        
        public GetInfoStudentResponseBody() {
        }
        
        public GetInfoStudentResponseBody(string GetInfoStudentResult) {
            this.GetInfoStudentResult = GetInfoStudentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CollegeDBWebServices.KlijentAplikacija4.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CollegeDBWebServices.KlijentAplikacija4.WebService1Soap>, CollegeDBWebServices.KlijentAplikacija4.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse CollegeDBWebServices.KlijentAplikacija4.WebService1Soap.HelloWorld(CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest inValue = new CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest();
            inValue.Body = new CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequestBody();
            CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse retVal = ((CollegeDBWebServices.KlijentAplikacija4.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse> CollegeDBWebServices.KlijentAplikacija4.WebService1Soap.HelloWorldAsync(CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.HelloWorldResponse> HelloWorldAsync() {
            CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest inValue = new CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequest();
            inValue.Body = new CollegeDBWebServices.KlijentAplikacija4.HelloWorldRequestBody();
            return ((CollegeDBWebServices.KlijentAplikacija4.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int GetSquare(int a) {
            return base.Channel.GetSquare(a);
        }
        
        public System.Threading.Tasks.Task<int> GetSquareAsync(int a) {
            return base.Channel.GetSquareAsync(a);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse CollegeDBWebServices.KlijentAplikacija4.WebService1Soap.GetInfoStudent(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest request) {
            return base.Channel.GetInfoStudent(request);
        }
        
        public string GetInfoStudent(int id) {
            CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest inValue = new CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest();
            inValue.Body = new CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequestBody();
            inValue.Body.id = id;
            CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse retVal = ((CollegeDBWebServices.KlijentAplikacija4.WebService1Soap)(this)).GetInfoStudent(inValue);
            return retVal.Body.GetInfoStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse> CollegeDBWebServices.KlijentAplikacija4.WebService1Soap.GetInfoStudentAsync(CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest request) {
            return base.Channel.GetInfoStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentResponse> GetInfoStudentAsync(int id) {
            CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest inValue = new CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequest();
            inValue.Body = new CollegeDBWebServices.KlijentAplikacija4.GetInfoStudentRequestBody();
            inValue.Body.id = id;
            return ((CollegeDBWebServices.KlijentAplikacija4.WebService1Soap)(this)).GetInfoStudentAsync(inValue);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_F.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ch11_3_1Soap")]
    public interface ch11_3_1Soap {
        
        // CODEGEN: 命名空間 http://tempuri.org/ 的元素名稱  HelloWorldResult 未標示為 nillable，正在產生訊息合約
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApp_F.ServiceReference1.HelloWorldResponse HelloWorld(WebApp_F.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp_F.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApp_F.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fn_GetSum", ReplyAction="*")]
        int fn_GetSum(int i_F, int i_S);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fn_GetSum", ReplyAction="*")]
        System.Threading.Tasks.Task<int> fn_GetSumAsync(int i_F, int i_S);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApp_F.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApp_F.ServiceReference1.HelloWorldRequestBody Body) {
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
        public WebApp_F.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApp_F.ServiceReference1.HelloWorldResponseBody Body) {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ch11_3_1SoapChannel : WebApp_F.ServiceReference1.ch11_3_1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ch11_3_1SoapClient : System.ServiceModel.ClientBase<WebApp_F.ServiceReference1.ch11_3_1Soap>, WebApp_F.ServiceReference1.ch11_3_1Soap {
        
        public ch11_3_1SoapClient() {
        }
        
        public ch11_3_1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ch11_3_1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ch11_3_1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ch11_3_1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp_F.ServiceReference1.HelloWorldResponse WebApp_F.ServiceReference1.ch11_3_1Soap.HelloWorld(WebApp_F.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApp_F.ServiceReference1.HelloWorldRequest inValue = new WebApp_F.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApp_F.ServiceReference1.HelloWorldRequestBody();
            WebApp_F.ServiceReference1.HelloWorldResponse retVal = ((WebApp_F.ServiceReference1.ch11_3_1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp_F.ServiceReference1.HelloWorldResponse> WebApp_F.ServiceReference1.ch11_3_1Soap.HelloWorldAsync(WebApp_F.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp_F.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApp_F.ServiceReference1.HelloWorldRequest inValue = new WebApp_F.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApp_F.ServiceReference1.HelloWorldRequestBody();
            return ((WebApp_F.ServiceReference1.ch11_3_1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int fn_GetSum(int i_F, int i_S) {
            return base.Channel.fn_GetSum(i_F, i_S);
        }
        
        public System.Threading.Tasks.Task<int> fn_GetSumAsync(int i_F, int i_S) {
            return base.Channel.fn_GetSumAsync(i_F, i_S);
        }
    }
}

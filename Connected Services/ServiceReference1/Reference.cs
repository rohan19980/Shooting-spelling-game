﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace spelltoscorebyamin.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceExampleSoap")]
    public interface WebServiceExampleSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        spelltoscorebyamin.ServiceReference1.HelloWorldResponse HelloWorld(spelltoscorebyamin.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.HelloWorldResponse> HelloWorldAsync(spelltoscorebyamin.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name player from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveStars", ReplyAction="*")]
        spelltoscorebyamin.ServiceReference1.SaveStarsResponse SaveStars(spelltoscorebyamin.ServiceReference1.SaveStarsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveStars", ReplyAction="*")]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.SaveStarsResponse> SaveStarsAsync(spelltoscorebyamin.ServiceReference1.SaveStarsRequest request);
        
        // CODEGEN: Generating message contract since element name ShowScoresResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowScores", ReplyAction="*")]
        spelltoscorebyamin.ServiceReference1.ShowScoresResponse ShowScores(spelltoscorebyamin.ServiceReference1.ShowScoresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowScores", ReplyAction="*")]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.ShowScoresResponse> ShowScoresAsync(spelltoscorebyamin.ServiceReference1.ShowScoresRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public spelltoscorebyamin.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(spelltoscorebyamin.ServiceReference1.HelloWorldRequestBody Body) {
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
        public spelltoscorebyamin.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(spelltoscorebyamin.ServiceReference1.HelloWorldResponseBody Body) {
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
    public partial class SaveStarsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveStars", Namespace="http://tempuri.org/", Order=0)]
        public spelltoscorebyamin.ServiceReference1.SaveStarsRequestBody Body;
        
        public SaveStarsRequest() {
        }
        
        public SaveStarsRequest(spelltoscorebyamin.ServiceReference1.SaveStarsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveStarsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int starsCount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string player;
        
        public SaveStarsRequestBody() {
        }
        
        public SaveStarsRequestBody(int starsCount, string player) {
            this.starsCount = starsCount;
            this.player = player;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveStarsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveStarsResponse", Namespace="http://tempuri.org/", Order=0)]
        public spelltoscorebyamin.ServiceReference1.SaveStarsResponseBody Body;
        
        public SaveStarsResponse() {
        }
        
        public SaveStarsResponse(spelltoscorebyamin.ServiceReference1.SaveStarsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveStarsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool SaveStarsResult;
        
        public SaveStarsResponseBody() {
        }
        
        public SaveStarsResponseBody(bool SaveStarsResult) {
            this.SaveStarsResult = SaveStarsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowScoresRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowScores", Namespace="http://tempuri.org/", Order=0)]
        public spelltoscorebyamin.ServiceReference1.ShowScoresRequestBody Body;
        
        public ShowScoresRequest() {
        }
        
        public ShowScoresRequest(spelltoscorebyamin.ServiceReference1.ShowScoresRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ShowScoresRequestBody {
        
        public ShowScoresRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowScoresResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowScoresResponse", Namespace="http://tempuri.org/", Order=0)]
        public spelltoscorebyamin.ServiceReference1.ShowScoresResponseBody Body;
        
        public ShowScoresResponse() {
        }
        
        public ShowScoresResponse(spelltoscorebyamin.ServiceReference1.ShowScoresResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowScoresResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ShowScoresResult;
        
        public ShowScoresResponseBody() {
        }
        
        public ShowScoresResponseBody(string ShowScoresResult) {
            this.ShowScoresResult = ShowScoresResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceExampleSoapChannel : spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceExampleSoapClient : System.ServiceModel.ClientBase<spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap>, spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap {
        
        public WebServiceExampleSoapClient() {
        }
        
        public WebServiceExampleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceExampleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceExampleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceExampleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        spelltoscorebyamin.ServiceReference1.HelloWorldResponse spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.HelloWorld(spelltoscorebyamin.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            spelltoscorebyamin.ServiceReference1.HelloWorldRequest inValue = new spelltoscorebyamin.ServiceReference1.HelloWorldRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.HelloWorldRequestBody();
            spelltoscorebyamin.ServiceReference1.HelloWorldResponse retVal = ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.HelloWorldResponse> spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.HelloWorldAsync(spelltoscorebyamin.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            spelltoscorebyamin.ServiceReference1.HelloWorldRequest inValue = new spelltoscorebyamin.ServiceReference1.HelloWorldRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.HelloWorldRequestBody();
            return ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        spelltoscorebyamin.ServiceReference1.SaveStarsResponse spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.SaveStars(spelltoscorebyamin.ServiceReference1.SaveStarsRequest request) {
            return base.Channel.SaveStars(request);
        }
        
        public bool SaveStars(int starsCount, string player) {
            spelltoscorebyamin.ServiceReference1.SaveStarsRequest inValue = new spelltoscorebyamin.ServiceReference1.SaveStarsRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.SaveStarsRequestBody();
            inValue.Body.starsCount = starsCount;
            inValue.Body.player = player;
            spelltoscorebyamin.ServiceReference1.SaveStarsResponse retVal = ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).SaveStars(inValue);
            return retVal.Body.SaveStarsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.SaveStarsResponse> spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.SaveStarsAsync(spelltoscorebyamin.ServiceReference1.SaveStarsRequest request) {
            return base.Channel.SaveStarsAsync(request);
        }
        
        public System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.SaveStarsResponse> SaveStarsAsync(int starsCount, string player) {
            spelltoscorebyamin.ServiceReference1.SaveStarsRequest inValue = new spelltoscorebyamin.ServiceReference1.SaveStarsRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.SaveStarsRequestBody();
            inValue.Body.starsCount = starsCount;
            inValue.Body.player = player;
            return ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).SaveStarsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        spelltoscorebyamin.ServiceReference1.ShowScoresResponse spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.ShowScores(spelltoscorebyamin.ServiceReference1.ShowScoresRequest request) {
            return base.Channel.ShowScores(request);
        }
        
        public string ShowScores() {
            spelltoscorebyamin.ServiceReference1.ShowScoresRequest inValue = new spelltoscorebyamin.ServiceReference1.ShowScoresRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.ShowScoresRequestBody();
            spelltoscorebyamin.ServiceReference1.ShowScoresResponse retVal = ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).ShowScores(inValue);
            return retVal.Body.ShowScoresResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.ShowScoresResponse> spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap.ShowScoresAsync(spelltoscorebyamin.ServiceReference1.ShowScoresRequest request) {
            return base.Channel.ShowScoresAsync(request);
        }
        
        public System.Threading.Tasks.Task<spelltoscorebyamin.ServiceReference1.ShowScoresResponse> ShowScoresAsync() {
            spelltoscorebyamin.ServiceReference1.ShowScoresRequest inValue = new spelltoscorebyamin.ServiceReference1.ShowScoresRequest();
            inValue.Body = new spelltoscorebyamin.ServiceReference1.ShowScoresRequestBody();
            return ((spelltoscorebyamin.ServiceReference1.WebServiceExampleSoap)(this)).ShowScoresAsync(inValue);
        }
    }
}

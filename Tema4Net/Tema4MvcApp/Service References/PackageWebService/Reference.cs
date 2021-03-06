﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tema4MvcApp.PackageWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice/", ConfigurationName="PackageWebService.PackageWS")]
    public interface PackageWS {
        
        // CODEGEN: Generating message contract since element name packageName from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/searchRequest", ReplyAction="http://webservice/PackageWS/searchResponse")]
        Tema4MvcApp.PackageWebService.searchResponse search(Tema4MvcApp.PackageWebService.searchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/searchRequest", ReplyAction="http://webservice/PackageWS/searchResponse")]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.searchResponse> searchAsync(Tema4MvcApp.PackageWebService.searchRequest request);
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/verifyStatusRequest", ReplyAction="http://webservice/PackageWS/verifyStatusResponse")]
        Tema4MvcApp.PackageWebService.verifyStatusResponse verifyStatus(Tema4MvcApp.PackageWebService.verifyStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/verifyStatusRequest", ReplyAction="http://webservice/PackageWS/verifyStatusResponse")]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.verifyStatusResponse> verifyStatusAsync(Tema4MvcApp.PackageWebService.verifyStatusRequest request);
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getClientPackageRequest", ReplyAction="http://webservice/PackageWS/getClientPackageResponse")]
        Tema4MvcApp.PackageWebService.getClientPackageResponse getClientPackage(Tema4MvcApp.PackageWebService.getClientPackageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getClientPackageRequest", ReplyAction="http://webservice/PackageWS/getClientPackageResponse")]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientPackageResponse> getClientPackageAsync(Tema4MvcApp.PackageWebService.getClientPackageRequest request);
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getClientNameByIdRequest", ReplyAction="http://webservice/PackageWS/getClientNameByIdResponse")]
        Tema4MvcApp.PackageWebService.getClientNameByIdResponse getClientNameById(Tema4MvcApp.PackageWebService.getClientNameByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getClientNameByIdRequest", ReplyAction="http://webservice/PackageWS/getClientNameByIdResponse")]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientNameByIdResponse> getClientNameByIdAsync(Tema4MvcApp.PackageWebService.getClientNameByIdRequest request);
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getPackageNameByIdRequest", ReplyAction="http://webservice/PackageWS/getPackageNameByIdResponse")]
        Tema4MvcApp.PackageWebService.getPackageNameByIdResponse getPackageNameById(Tema4MvcApp.PackageWebService.getPackageNameByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice/PackageWS/getPackageNameByIdRequest", ReplyAction="http://webservice/PackageWS/getPackageNameByIdResponse")]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getPackageNameByIdResponse> getPackageNameByIdAsync(Tema4MvcApp.PackageWebService.getPackageNameByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class searchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="search", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.searchRequestBody Body;
        
        public searchRequest() {
        }
        
        public searchRequest(Tema4MvcApp.PackageWebService.searchRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class searchRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string packageName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int clientId;
        
        public searchRequestBody() {
        }
        
        public searchRequestBody(string packageName, int clientId) {
            this.packageName = packageName;
            this.clientId = clientId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class searchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="searchResponse", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.searchResponseBody Body;
        
        public searchResponse() {
        }
        
        public searchResponse(Tema4MvcApp.PackageWebService.searchResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class searchResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public searchResponseBody() {
        }
        
        public searchResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class verifyStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="verifyStatus", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.verifyStatusRequestBody Body;
        
        public verifyStatusRequest() {
        }
        
        public verifyStatusRequest(Tema4MvcApp.PackageWebService.verifyStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class verifyStatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int packageId;
        
        public verifyStatusRequestBody() {
        }
        
        public verifyStatusRequestBody(int packageId) {
            this.packageId = packageId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class verifyStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="verifyStatusResponse", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.verifyStatusResponseBody Body;
        
        public verifyStatusResponse() {
        }
        
        public verifyStatusResponse(Tema4MvcApp.PackageWebService.verifyStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class verifyStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public verifyStatusResponseBody() {
        }
        
        public verifyStatusResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getClientPackageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getClientPackage", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getClientPackageRequestBody Body;
        
        public getClientPackageRequest() {
        }
        
        public getClientPackageRequest(Tema4MvcApp.PackageWebService.getClientPackageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getClientPackageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int clientId;
        
        public getClientPackageRequestBody() {
        }
        
        public getClientPackageRequestBody(int clientId) {
            this.clientId = clientId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getClientPackageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getClientPackageResponse", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getClientPackageResponseBody Body;
        
        public getClientPackageResponse() {
        }
        
        public getClientPackageResponse(Tema4MvcApp.PackageWebService.getClientPackageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getClientPackageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getClientPackageResponseBody() {
        }
        
        public getClientPackageResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getClientNameByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getClientNameById", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getClientNameByIdRequestBody Body;
        
        public getClientNameByIdRequest() {
        }
        
        public getClientNameByIdRequest(Tema4MvcApp.PackageWebService.getClientNameByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getClientNameByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idClient;
        
        public getClientNameByIdRequestBody() {
        }
        
        public getClientNameByIdRequestBody(int idClient) {
            this.idClient = idClient;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getClientNameByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getClientNameByIdResponse", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getClientNameByIdResponseBody Body;
        
        public getClientNameByIdResponse() {
        }
        
        public getClientNameByIdResponse(Tema4MvcApp.PackageWebService.getClientNameByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getClientNameByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getClientNameByIdResponseBody() {
        }
        
        public getClientNameByIdResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getPackageNameByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getPackageNameById", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getPackageNameByIdRequestBody Body;
        
        public getPackageNameByIdRequest() {
        }
        
        public getPackageNameByIdRequest(Tema4MvcApp.PackageWebService.getPackageNameByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getPackageNameByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idPackage;
        
        public getPackageNameByIdRequestBody() {
        }
        
        public getPackageNameByIdRequestBody(int idPackage) {
            this.idPackage = idPackage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getPackageNameByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getPackageNameByIdResponse", Namespace="http://webservice/", Order=0)]
        public Tema4MvcApp.PackageWebService.getPackageNameByIdResponseBody Body;
        
        public getPackageNameByIdResponse() {
        }
        
        public getPackageNameByIdResponse(Tema4MvcApp.PackageWebService.getPackageNameByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getPackageNameByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getPackageNameByIdResponseBody() {
        }
        
        public getPackageNameByIdResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PackageWSChannel : Tema4MvcApp.PackageWebService.PackageWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PackageWSClient : System.ServiceModel.ClientBase<Tema4MvcApp.PackageWebService.PackageWS>, Tema4MvcApp.PackageWebService.PackageWS {
        
        public PackageWSClient() {
        }
        
        public PackageWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PackageWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema4MvcApp.PackageWebService.searchResponse Tema4MvcApp.PackageWebService.PackageWS.search(Tema4MvcApp.PackageWebService.searchRequest request) {
            return base.Channel.search(request);
        }
        
        public string search(string packageName, int clientId) {
            Tema4MvcApp.PackageWebService.searchRequest inValue = new Tema4MvcApp.PackageWebService.searchRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.searchRequestBody();
            inValue.Body.packageName = packageName;
            inValue.Body.clientId = clientId;
            Tema4MvcApp.PackageWebService.searchResponse retVal = ((Tema4MvcApp.PackageWebService.PackageWS)(this)).search(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.searchResponse> Tema4MvcApp.PackageWebService.PackageWS.searchAsync(Tema4MvcApp.PackageWebService.searchRequest request) {
            return base.Channel.searchAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.searchResponse> searchAsync(string packageName, int clientId) {
            Tema4MvcApp.PackageWebService.searchRequest inValue = new Tema4MvcApp.PackageWebService.searchRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.searchRequestBody();
            inValue.Body.packageName = packageName;
            inValue.Body.clientId = clientId;
            return ((Tema4MvcApp.PackageWebService.PackageWS)(this)).searchAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema4MvcApp.PackageWebService.verifyStatusResponse Tema4MvcApp.PackageWebService.PackageWS.verifyStatus(Tema4MvcApp.PackageWebService.verifyStatusRequest request) {
            return base.Channel.verifyStatus(request);
        }
        
        public string verifyStatus(int packageId) {
            Tema4MvcApp.PackageWebService.verifyStatusRequest inValue = new Tema4MvcApp.PackageWebService.verifyStatusRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.verifyStatusRequestBody();
            inValue.Body.packageId = packageId;
            Tema4MvcApp.PackageWebService.verifyStatusResponse retVal = ((Tema4MvcApp.PackageWebService.PackageWS)(this)).verifyStatus(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.verifyStatusResponse> Tema4MvcApp.PackageWebService.PackageWS.verifyStatusAsync(Tema4MvcApp.PackageWebService.verifyStatusRequest request) {
            return base.Channel.verifyStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.verifyStatusResponse> verifyStatusAsync(int packageId) {
            Tema4MvcApp.PackageWebService.verifyStatusRequest inValue = new Tema4MvcApp.PackageWebService.verifyStatusRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.verifyStatusRequestBody();
            inValue.Body.packageId = packageId;
            return ((Tema4MvcApp.PackageWebService.PackageWS)(this)).verifyStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema4MvcApp.PackageWebService.getClientPackageResponse Tema4MvcApp.PackageWebService.PackageWS.getClientPackage(Tema4MvcApp.PackageWebService.getClientPackageRequest request) {
            return base.Channel.getClientPackage(request);
        }
        
        public string getClientPackage(int clientId) {
            Tema4MvcApp.PackageWebService.getClientPackageRequest inValue = new Tema4MvcApp.PackageWebService.getClientPackageRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getClientPackageRequestBody();
            inValue.Body.clientId = clientId;
            Tema4MvcApp.PackageWebService.getClientPackageResponse retVal = ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getClientPackage(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientPackageResponse> Tema4MvcApp.PackageWebService.PackageWS.getClientPackageAsync(Tema4MvcApp.PackageWebService.getClientPackageRequest request) {
            return base.Channel.getClientPackageAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientPackageResponse> getClientPackageAsync(int clientId) {
            Tema4MvcApp.PackageWebService.getClientPackageRequest inValue = new Tema4MvcApp.PackageWebService.getClientPackageRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getClientPackageRequestBody();
            inValue.Body.clientId = clientId;
            return ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getClientPackageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema4MvcApp.PackageWebService.getClientNameByIdResponse Tema4MvcApp.PackageWebService.PackageWS.getClientNameById(Tema4MvcApp.PackageWebService.getClientNameByIdRequest request) {
            return base.Channel.getClientNameById(request);
        }
        
        public string getClientNameById(int idClient) {
            Tema4MvcApp.PackageWebService.getClientNameByIdRequest inValue = new Tema4MvcApp.PackageWebService.getClientNameByIdRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getClientNameByIdRequestBody();
            inValue.Body.idClient = idClient;
            Tema4MvcApp.PackageWebService.getClientNameByIdResponse retVal = ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getClientNameById(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientNameByIdResponse> Tema4MvcApp.PackageWebService.PackageWS.getClientNameByIdAsync(Tema4MvcApp.PackageWebService.getClientNameByIdRequest request) {
            return base.Channel.getClientNameByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getClientNameByIdResponse> getClientNameByIdAsync(int idClient) {
            Tema4MvcApp.PackageWebService.getClientNameByIdRequest inValue = new Tema4MvcApp.PackageWebService.getClientNameByIdRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getClientNameByIdRequestBody();
            inValue.Body.idClient = idClient;
            return ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getClientNameByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tema4MvcApp.PackageWebService.getPackageNameByIdResponse Tema4MvcApp.PackageWebService.PackageWS.getPackageNameById(Tema4MvcApp.PackageWebService.getPackageNameByIdRequest request) {
            return base.Channel.getPackageNameById(request);
        }
        
        public string getPackageNameById(int idPackage) {
            Tema4MvcApp.PackageWebService.getPackageNameByIdRequest inValue = new Tema4MvcApp.PackageWebService.getPackageNameByIdRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getPackageNameByIdRequestBody();
            inValue.Body.idPackage = idPackage;
            Tema4MvcApp.PackageWebService.getPackageNameByIdResponse retVal = ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getPackageNameById(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getPackageNameByIdResponse> Tema4MvcApp.PackageWebService.PackageWS.getPackageNameByIdAsync(Tema4MvcApp.PackageWebService.getPackageNameByIdRequest request) {
            return base.Channel.getPackageNameByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tema4MvcApp.PackageWebService.getPackageNameByIdResponse> getPackageNameByIdAsync(int idPackage) {
            Tema4MvcApp.PackageWebService.getPackageNameByIdRequest inValue = new Tema4MvcApp.PackageWebService.getPackageNameByIdRequest();
            inValue.Body = new Tema4MvcApp.PackageWebService.getPackageNameByIdRequestBody();
            inValue.Body.idPackage = idPackage;
            return ((Tema4MvcApp.PackageWebService.PackageWS)(this)).getPackageNameByIdAsync(inValue);
        }
    }
}

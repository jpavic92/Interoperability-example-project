//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShazamClient.SoapService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapService.TrackSearchServiceSoap")]
    public interface TrackSearchServiceSoap {
        
        // CODEGEN: Generating message contract since element name keyword from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Search", ReplyAction="*")]
        ShazamClient.SoapService.SearchResponse Search(ShazamClient.SoapService.SearchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Search", ReplyAction="*")]
        System.Threading.Tasks.Task<ShazamClient.SoapService.SearchResponse> SearchAsync(ShazamClient.SoapService.SearchRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Search", Namespace="http://tempuri.org/", Order=0)]
        public ShazamClient.SoapService.SearchRequestBody Body;
        
        public SearchRequest() {
        }
        
        public SearchRequest(ShazamClient.SoapService.SearchRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string keyword;
        
        public SearchRequestBody() {
        }
        
        public SearchRequestBody(string keyword) {
            this.keyword = keyword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchResponse", Namespace="http://tempuri.org/", Order=0)]
        public ShazamClient.SoapService.SearchResponseBody Body;
        
        public SearchResponse() {
        }
        
        public SearchResponse(ShazamClient.SoapService.SearchResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SearchResult;
        
        public SearchResponseBody() {
        }
        
        public SearchResponseBody(int SearchResult) {
            this.SearchResult = SearchResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TrackSearchServiceSoapChannel : ShazamClient.SoapService.TrackSearchServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrackSearchServiceSoapClient : System.ServiceModel.ClientBase<ShazamClient.SoapService.TrackSearchServiceSoap>, ShazamClient.SoapService.TrackSearchServiceSoap {
        
        public TrackSearchServiceSoapClient() {
        }
        
        public TrackSearchServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrackSearchServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrackSearchServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrackSearchServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ShazamClient.SoapService.SearchResponse ShazamClient.SoapService.TrackSearchServiceSoap.Search(ShazamClient.SoapService.SearchRequest request) {
            return base.Channel.Search(request);
        }
        
        public int Search(string keyword) {
            ShazamClient.SoapService.SearchRequest inValue = new ShazamClient.SoapService.SearchRequest();
            inValue.Body = new ShazamClient.SoapService.SearchRequestBody();
            inValue.Body.keyword = keyword;
            ShazamClient.SoapService.SearchResponse retVal = ((ShazamClient.SoapService.TrackSearchServiceSoap)(this)).Search(inValue);
            return retVal.Body.SearchResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ShazamClient.SoapService.SearchResponse> ShazamClient.SoapService.TrackSearchServiceSoap.SearchAsync(ShazamClient.SoapService.SearchRequest request) {
            return base.Channel.SearchAsync(request);
        }
        
        public System.Threading.Tasks.Task<ShazamClient.SoapService.SearchResponse> SearchAsync(string keyword) {
            ShazamClient.SoapService.SearchRequest inValue = new ShazamClient.SoapService.SearchRequest();
            inValue.Body = new ShazamClient.SoapService.SearchRequestBody();
            inValue.Body.keyword = keyword;
            return ((ShazamClient.SoapService.TrackSearchServiceSoap)(this)).SearchAsync(inValue);
        }
    }
}

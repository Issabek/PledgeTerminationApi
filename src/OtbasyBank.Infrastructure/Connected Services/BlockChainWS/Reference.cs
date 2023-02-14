﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlockChainWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hcsbk.kz/", ConfigurationName="BlockChainWS.BlockchainWSSoap")]
    public interface BlockchainWSSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/createRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BlockChainWS.createRecordResponse createRecord(BlockChainWS.createRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/createRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<BlockChainWS.createRecordResponse> createRecordAsync(BlockChainWS.createRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/payedRecord", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BlockChainWS.payedRecordResponse payedRecord(BlockChainWS.payedRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/payedRecord", ReplyAction="*")]
        System.Threading.Tasks.Task<BlockChainWS.payedRecordResponse> payedRecordAsync(BlockChainWS.payedRecordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/getTerminatePledge", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BlockChainWS.getTerminatePledgeResponse getTerminatePledge(BlockChainWS.getTerminatePledgeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/getTerminatePledge", ReplyAction="*")]
        System.Threading.Tasks.Task<BlockChainWS.getTerminatePledgeResponse> getTerminatePledgeAsync(BlockChainWS.getTerminatePledgeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/getDocument", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BlockChainWS.getDocumentResponse getDocument(BlockChainWS.getDocumentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hcsbk.kz/getDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<BlockChainWS.getDocumentResponse> getDocumentAsync(BlockChainWS.getDocumentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createRecord", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class createRecordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=1)]
        public string Data;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=2)]
        public string Signatures;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=3)]
        public string DocHash;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=4)]
        public string Name;
        
        public createRecordRequest()
        {
        }
        
        public createRecordRequest(string token, string Data, string Signatures, string DocHash, string Name)
        {
            this.token = token;
            this.Data = Data;
            this.Signatures = Signatures;
            this.DocHash = DocHash;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createRecordResponse", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class createRecordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string createRecordResult;
        
        public createRecordResponse()
        {
        }
        
        public createRecordResponse(string createRecordResult)
        {
            this.createRecordResult = createRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="payedRecord", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class payedRecordRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=1)]
        public string Data;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=2)]
        public string Signatures;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=3)]
        public string DocHash;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=4)]
        public string Name;
        
        public payedRecordRequest()
        {
        }
        
        public payedRecordRequest(string token, string Data, string Signatures, string DocHash, string Name)
        {
            this.token = token;
            this.Data = Data;
            this.Signatures = Signatures;
            this.DocHash = DocHash;
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="payedRecordResponse", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class payedRecordResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string payedRecordResult;
        
        public payedRecordResponse()
        {
        }
        
        public payedRecordResponse(string payedRecordResult)
        {
            this.payedRecordResult = payedRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTerminatePledge", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class getTerminatePledgeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=1)]
        public string AppId;
        
        public getTerminatePledgeRequest()
        {
        }
        
        public getTerminatePledgeRequest(string token, string AppId)
        {
            this.token = token;
            this.AppId = AppId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTerminatePledgeResponse", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class getTerminatePledgeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string getTerminatePledgeResult;
        
        public getTerminatePledgeResponse()
        {
        }
        
        public getTerminatePledgeResponse(string getTerminatePledgeResult)
        {
            this.getTerminatePledgeResult = getTerminatePledgeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDocument", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class getDocumentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=1)]
        public string NotificationId;
        
        public getDocumentRequest()
        {
        }
        
        public getDocumentRequest(string token, string NotificationId)
        {
            this.token = token;
            this.NotificationId = NotificationId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDocumentResponse", WrapperNamespace="http://hcsbk.kz/", IsWrapped=true)]
    public partial class getDocumentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://hcsbk.kz/", Order=0)]
        public string getDocumentResult;
        
        public getDocumentResponse()
        {
        }
        
        public getDocumentResponse(string getDocumentResult)
        {
            this.getDocumentResult = getDocumentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface BlockchainWSSoapChannel : BlockChainWS.BlockchainWSSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class BlockchainWSSoapClient : System.ServiceModel.ClientBase<BlockChainWS.BlockchainWSSoap>, BlockChainWS.BlockchainWSSoap
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BlockchainWSSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(BlockchainWSSoapClient.GetBindingForEndpoint(endpointConfiguration), BlockchainWSSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlockchainWSSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BlockchainWSSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlockchainWSSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BlockchainWSSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlockchainWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public BlockChainWS.createRecordResponse createRecord(BlockChainWS.createRecordRequest request)
        {
            return base.Channel.createRecord(request);
        }
        
        public System.Threading.Tasks.Task<BlockChainWS.createRecordResponse> createRecordAsync(BlockChainWS.createRecordRequest request)
        {
            return base.Channel.createRecordAsync(request);
        }
        
        public BlockChainWS.payedRecordResponse payedRecord(BlockChainWS.payedRecordRequest request)
        {
            return base.Channel.payedRecord(request);
        }
        
        public System.Threading.Tasks.Task<BlockChainWS.payedRecordResponse> payedRecordAsync(BlockChainWS.payedRecordRequest request)
        {
            return base.Channel.payedRecordAsync(request);
        }
        
        public BlockChainWS.getTerminatePledgeResponse getTerminatePledge(BlockChainWS.getTerminatePledgeRequest request)
        {
            return base.Channel.getTerminatePledge(request);
        }
        
        public System.Threading.Tasks.Task<BlockChainWS.getTerminatePledgeResponse> getTerminatePledgeAsync(BlockChainWS.getTerminatePledgeRequest request)
        {
            return base.Channel.getTerminatePledgeAsync(request);
        }
        
        public BlockChainWS.getDocumentResponse getDocument(BlockChainWS.getDocumentRequest request)
        {
            return base.Channel.getDocument(request);
        }
        
        public System.Threading.Tasks.Task<BlockChainWS.getDocumentResponse> getDocumentAsync(BlockChainWS.getDocumentRequest request)
        {
            return base.Channel.getDocumentAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BlockchainWSSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BlockchainWSSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BlockchainWSSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://192.168.55.26/CBSProxyWS/blockchainws.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.BlockchainWSSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://192.168.55.26/CBSProxyWS/blockchainws.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BlockchainWSSoap,
            
            BlockchainWSSoap12,
        }
    }
}
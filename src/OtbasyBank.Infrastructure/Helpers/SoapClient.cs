using LoanWS;
using Microsoft.Extensions.Configuration;
using PrintWS;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Xml;

namespace OtbasyBank.Infrastructure.Helpers;

public class SoapClient
{
    public static IConfiguration? _configuration;
    private static string _clientUrl;
    private static string _accountUrl;
    private static string _ePayAuctionUrl;
    private static string _egovUrl;
    private static string _loanUrl;
    private static string _blockchainUrl;
    private static string _tokenAuthUrl;
    private static string _referenceUrl;
    private static string _printUrl;

    public SoapClient(IConfiguration configuration)
    {
        _configuration = configuration;
        _accountUrl = _configuration["ServiceBus:UrlAccountWS"];
        _clientUrl = _configuration["ServiceBus:UrlClientWS"];
        _ePayAuctionUrl = _configuration["ServiceBus:UrlEPayAuctionWS"];
        _tokenAuthUrl = _configuration["ServiceBus:UrlTokenAuthWS"];
        _egovUrl = _configuration["ServiceBus:UrlEgovWS"];
        _loanUrl = _configuration["ServiceBus:UrlLoanWS"];
        _referenceUrl = _configuration["ServiceBus:UrlReferenceWS"];
        _blockchainUrl = _configuration["ServiceBus:UrlBlockChainWS"];
        _printUrl = _configuration["ServiceBus:UrlPrintWS"];
    }
    public TokenAuthWS.TokenAuthWSSoapClient getTokenWSClient()
    {
        var token = new TokenAuthWS.TokenAuthWSSoapClient(TokenAuthWS.TokenAuthWSSoapClient.EndpointConfiguration.TokenAuthWSSoap12, _tokenAuthUrl);
        token.Endpoint.Binding = GetBinding(_tokenAuthUrl);
        token.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return token;
    }
    public LoanWSSoapClient getLoanWSClient()
    {
        var loan = new LoanWSSoapClient(LoanWSSoapClient.EndpointConfiguration.LoanWSSoap12, _loanUrl);
        loan.Endpoint.Binding = GetBinding(_loanUrl);
        loan.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return loan;
    }    
    public PrintWSSoapClient getPrintWSClient()
    {
        var print = new PrintWSSoapClient(PrintWSSoapClient.EndpointConfiguration.PrintWSSoap12, _printUrl);
        print.Endpoint.Binding = GetBinding(_printUrl);
        print.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return print;
    }
    public EpayAuctionWs.EPay_AuctionWSSoapClient getEpayAuctionWSClient()
    {
        var auction = new EpayAuctionWs.EPay_AuctionWSSoapClient(EpayAuctionWs.EPay_AuctionWSSoapClient.EndpointConfiguration.EPay_AuctionWSSoap12, _ePayAuctionUrl);
        auction.Endpoint.Binding = GetBinding(_ePayAuctionUrl);
        auction.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return auction;
    }
    public ClientWS.ClientWSSoapClient getClientWSClient()
    {
        var client = new ClientWS.ClientWSSoapClient(ClientWS.ClientWSSoapClient.EndpointConfiguration.ClientWSSoap12, _clientUrl);
        client.Endpoint.Binding = GetBinding(_clientUrl);
        client.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return client;
    }
    public AccountWS.AccountWSSoapClient getAccountWSClient()
    {
        var account = new AccountWS.AccountWSSoapClient(AccountWS.AccountWSSoapClient.EndpointConfiguration.AccountWSSoap12, _accountUrl);
        account.Endpoint.Binding = GetBinding(_accountUrl);
        account.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return account;
    }
        public BlockChainWS.BlockchainWSSoapClient getBlockchainWSClient()
    {
        var blockchain = new BlockChainWS.BlockchainWSSoapClient(BlockChainWS.BlockchainWSSoapClient.EndpointConfiguration.BlockchainWSSoap12, _blockchainUrl);
        blockchain.Endpoint.Binding = GetBinding(_blockchainUrl);
        blockchain.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return blockchain;
    }        
    public ReferenceWS.ReferenceWSSoapClient getReferenceWsClient()
    {
        var reference = new ReferenceWS.ReferenceWSSoapClient(ReferenceWS.ReferenceWSSoapClient.EndpointConfiguration.ReferenceWSSoap12, _referenceUrl);
        reference.Endpoint.Binding = GetBinding(_referenceUrl);
        reference.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return reference;
    }
            
    public EgovWS.EgovWSSoapClient getEgovWSClient()
    {
        var egov = new EgovWS.EgovWSSoapClient(EgovWS.EgovWSSoapClient.EndpointConfiguration.EgovWSSoap12, _egovUrl);
        egov.Endpoint.Binding = GetBinding(_blockchainUrl);
        egov.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = IgnoreSslSertificate();
        return egov;
    }

    public static  BasicHttpBinding GetBinding(string url)
    {
        BasicHttpBinding result = new BasicHttpBinding();
        result.MaxBufferSize = int.MaxValue;
        result.ReaderQuotas = XmlDictionaryReaderQuotas.Max;
        result.MaxReceivedMessageSize = int.MaxValue;
        result.AllowCookies = true;

        if (url.Contains("https://"))
        {
            result.Security.Mode = BasicHttpSecurityMode.Transport;
        }
        else
        {
            result.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
        }

        return result;
    }

    public static X509ServiceCertificateAuthentication IgnoreSslSertificate() => new X509ServiceCertificateAuthentication()
    {
        CertificateValidationMode = X509CertificateValidationMode.None,
        RevocationMode = X509RevocationMode.NoCheck
    };
}

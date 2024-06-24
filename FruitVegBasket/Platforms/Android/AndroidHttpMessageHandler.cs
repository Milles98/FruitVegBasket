using System.Net.Security;
using FruitVegBasket.Interfaces;
using Xamarin.Android.Net;

namespace FruitVegBasket;

public class AndroidHttpMessageHandler : IPlatformHttpMessageHandler
{
    public HttpMessageHandler GetHttpMessageHandler() =>
        new AndroidMessageHandler
        {
            ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, sslPolicyErrors) =>
                certificate?.Issuer == "CN=localhost" || sslPolicyErrors == SslPolicyErrors.None
        };
}
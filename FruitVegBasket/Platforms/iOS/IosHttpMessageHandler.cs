using FruitVegBasket.Interfaces;
using Security;

namespace FruitVegBasket;

public class IosHttpMessageHandler : IPlatformHttpMessageHandler
{
    public HttpMessageHandler GetHttpMessageHandler() =>
        new NSUrlSessionHandler
        {
            TrustOverrideForUrl = (NSUrlSessionHandler sender, string url, SecTrust trust) =>
                url.StartsWith("https://localhost")
        };
}
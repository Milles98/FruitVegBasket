﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using FruitVegBasket.Interfaces;
using FruitVegBasket.Pages;
using FruitVegBasket.Services;
using FruitVegBasket.ViewModels;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace FruitVegBasket;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
            })
            .UseMauiCommunityToolkit();
        
        builder.Services.AddSingleton<IPlatformHttpMessageHandler>(sp =>
        {
#if ANDROID
            return new AndroidHttpMessageHandler();
#elif IOS
            return new IosHttpMessageHandler();
#endif
            return null;
        });

        builder.Services.AddHttpClient(Constants.AppConstants.HttpClientName, httpClient =>
            {
                var baseAddress = DeviceInfo.Platform == DevicePlatform.Android
                    ? "https://10.0.2.2:12345"
                    : "https://localhost:12345";
                httpClient.BaseAddress = new Uri(baseAddress);
            })
            .ConfigureHttpMessageHandlerBuilder(configureBuilder =>
            {
                var platformHttpMessageHandler = configureBuilder.Services.GetRequiredService<IPlatformHttpMessageHandler>();
                configureBuilder.PrimaryHandler = platformHttpMessageHandler.GetHttpMessageHandler();
            });
        
        builder.Services.AddSingleton<CategoryService>();
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddSingleton<HomePage>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
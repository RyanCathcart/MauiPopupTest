using CommunityToolkit.Maui;
using MauiPopupTest.Services;
using MauiPopupTest.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiPopupTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit(options =>
            {
                options.SetShouldEnableSnackbarOnWindows(true);
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransientWithShellRoute<MainPage, MainViewModel>(nameof(MainPage));
        builder.Services.AddTransient<IAlertService, AlertService>();
        //builder.Services.AddTransient<MainPage, MainViewModel>();
        builder.Services.AddTransientWithShellRoute<TestModalPage, TestModalPageViewModel>(nameof(TestModalPage));
        builder.Services.AddTransientPopup<ActionPopup, ActionPopupViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

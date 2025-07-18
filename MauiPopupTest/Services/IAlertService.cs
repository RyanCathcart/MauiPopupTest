using CommunityToolkit.Maui.Core;

namespace MauiPopupTest.Services;

public interface IAlertService
{
    Task ShowAlertAsync(string? title, string message, string cancelButton = "OK");

    Task ShowToastAsync(string message, ToastDuration duration = ToastDuration.Short, CancellationToken cancellationToken = default);
}

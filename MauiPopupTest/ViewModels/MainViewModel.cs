using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPopupTest.Services;

namespace MauiPopupTest.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IPopupService _popupService;
    private readonly IAlertService _alertService;

    public MainViewModel(IPopupService popupService, IAlertService alertService)
    {
        _popupService = popupService;
        this._alertService = alertService;
    }

    [RelayCommand]
    public async Task DisplayPopup()
    {
        var queryAttributes = new Dictionary<string, object>
        {
            { nameof(ActionPopupViewModel.Message), "This is a test message for the test Popup" }
        };

        await _popupService.ShowPopupAsync<ActionPopupViewModel>(
            Shell.Current, // Try changing to 'Shell.Current.Navigation'?
            options:PopupOptions.Empty,
            shellParameters: queryAttributes);

        //await Shell.Current.GoToAsync("", parameters: queryAttributes);
    }

    [RelayCommand]
    public Task DisplayModal()
    {
        return Shell.Current.GoToAsync("Modal");
    }

    [RelayCommand]
    public Task DisplayAlert()
    {
        return _alertService.ShowAlertAsync("Alert", "This is a test alert");
    }

    [RelayCommand]
    public async Task DisplayToast()
    {
        var cancellationTokenSource = new CancellationTokenSource();

        await _alertService.ShowToastAsync("This is a test toast", ToastDuration.Short, cancellationTokenSource.Token);
    }
}

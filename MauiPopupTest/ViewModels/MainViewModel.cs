using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiPopupTest.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IPopupService _popupService;

    public MainViewModel(IPopupService popupService)
    {
        _popupService = popupService;
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
    }
}

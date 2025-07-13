using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiPopupTest.ViewModels;

public partial class ActionPopupViewModel : ObservableObject, IQueryAttributable
{
    private readonly IPopupService _popupService;

    public ActionPopupViewModel(IPopupService popupService)
    {
        _popupService = popupService;
    }

    [ObservableProperty]
    public partial string Message { get; set; } = string.Empty;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Message = (string)query[nameof(Message)];
    }

    [RelayCommand]
    async Task OnPopupClosed()
    {
        await _popupService.ClosePopupAsync(Shell.Current);
    }
}

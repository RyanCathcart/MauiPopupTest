using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiPopupTest.ViewModels;

public partial class TestModalPageViewModel : ObservableObject
{
    public TestModalPageViewModel()
    {
        
    }

    [RelayCommand]
    public async Task CloseModal()
    {
        await Shell.Current.GoToAsync("..");
    }
}

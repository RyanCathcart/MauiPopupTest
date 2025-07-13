using MauiPopupTest.ViewModels;

namespace MauiPopupTest;

public partial class ActionPopup : ContentView
{
	public ActionPopup(ActionPopupViewModel actionPopupViewModel)
	{
		InitializeComponent();
		BindingContext = actionPopupViewModel;
    }
}
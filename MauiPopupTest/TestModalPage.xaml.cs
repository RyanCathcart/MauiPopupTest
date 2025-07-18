using MauiPopupTest.ViewModels;

namespace MauiPopupTest;

public partial class TestModalPage : ContentPage
{
	public TestModalPage(TestModalPageViewModel testModalPageViewModel)
	{
		InitializeComponent();
		BindingContext = testModalPageViewModel;
    }

    public void Close_Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}
namespace MauiPopupTest;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("Modal", typeof(TestModalPage));
    }
}

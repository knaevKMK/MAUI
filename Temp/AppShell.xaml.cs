namespace Temp;

using Temp.Pages;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(UserRegisterPage), typeof(UserRegisterPage));
        Routing.RegisterRoute(nameof(UserLoginPage), typeof(UserLoginPage));
        Routing.RegisterRoute(nameof(UserProfilePage), typeof(UserProfilePage));
        Routing.RegisterRoute(nameof(CountriesPhoneCodesPage), typeof(CountriesPhoneCodesPage));
    }
}

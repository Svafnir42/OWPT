using System.Security.AccessControl;

namespace Project___OWPT;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

	private async void CrateAccount_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new CreateAccountPage());
    }

	private async void Login_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new LoginPage());
    }
}
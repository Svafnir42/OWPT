namespace Project___OWPT;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void RegPage_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new RegistrationPage());
    }
}


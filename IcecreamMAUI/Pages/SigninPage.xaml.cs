namespace IcecreamMAUI.Pages;

public partial class SigninPage : ContentPage
{
	public SigninPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}
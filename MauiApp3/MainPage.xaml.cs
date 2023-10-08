
namespace MauiApp3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnDial(object sender, EventArgs e)
    {
		Button button = (Button)sender;
		try
		{
			PhoneDialer.Open(PhoneNum.Text);
		}
		catch
		{
			await DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");
		}
    }

    

	
}


namespace TabRendererCrash;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new MyTabbedPage());
    }
}

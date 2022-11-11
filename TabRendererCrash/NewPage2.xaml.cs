using System.Windows.Input;

namespace TabRendererCrash;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
	{
		InitializeComponent();
    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new OutsidePage());
    }
}

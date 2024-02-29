namespace MauiApp1;

public partial class EVFpage : ContentPage
{
	public EVFpage()
	{
		InitializeComponent();
	}

  

    private async void Nova_Faktura1_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovaFaktura());
    }
}
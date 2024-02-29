namespace MauiApp1;

public partial class EPFpage : ContentPage
{
	public EPFpage()
	{
		InitializeComponent();
	}



    private async void Nova_Faktura_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovaFaktura());
    }
}
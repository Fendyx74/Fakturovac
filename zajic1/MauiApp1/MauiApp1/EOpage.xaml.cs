namespace MauiApp1;

public partial class EOpage : ContentPage
{
	public EOpage()
	{
		InitializeComponent();
	}

    private async void Novy_Odberatel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovyOdberatel());
    }
}
namespace MauiApp1;

public partial class EDpage : ContentPage
{
	public EDpage()
	{
		InitializeComponent();
	}

    private async void Novy_Dodavatel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovyDodavatel());
    }
}
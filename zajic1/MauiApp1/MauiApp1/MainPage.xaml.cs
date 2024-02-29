namespace MauiApp1;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }
    private async void Button1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EPFpage());
    }
    private async void Button2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EVFpage());
    }

    private async void Button3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EDpage());
    }

    private async void Button4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EOpage());
    }



    
    
}


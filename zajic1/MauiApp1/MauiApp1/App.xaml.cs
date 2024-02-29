namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window =  base.CreateWindow(activationState);

		const int newWidth = 1600;
        const int newHight = 900;

        window.X = 500;
        window.Y = 200;

        window.Width = newWidth;
        window.Height = newHight;

        window.MinimumHeight = newHight;
        window.MinimumWidth = newWidth;

        window.MaximumHeight = newHight;
        window.MaximumWidth = newWidth;


        return window;
    }
}


namespace MauiAppHospedagem;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new views.hospedagemContratada());
	}
    protected override Window CreateWindow(IActivationState? activationState)
    {
		var window = base.CreateWindow(activationState);
		window.Width = 480;
		window.Height = 640;


        return window;
  }
}

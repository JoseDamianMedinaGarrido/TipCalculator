using TIpCalculator.Maui.ViewModels;

namespace TIpCalculator.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();	
    }
}
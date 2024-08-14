using BozkusMusic.ViewModels;

namespace BozkusMusic.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}
}
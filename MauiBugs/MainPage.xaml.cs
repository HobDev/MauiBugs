namespace MauiBugs;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		Picker picker = new Picker { Title = "Select Territory", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
		picker.SetBinding(Picker.ItemsSourceProperty, "TerritoryNames", BindingMode.OneTime);
		Content = picker;
		BindingContext = new MainViewModel();
	}


}


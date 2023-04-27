namespace MauiBugs;

public class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		Content = new VerticalStackLayout
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Children = {
				new SwipeView
				{
				  RightItems= new SwipeItems
				  (
					  new List<SwipeItem>
					  {
						  new SwipeItem{Text="Hello", BackgroundColor=Colors.AliceBlue},
					  }
				  ),
				  Content=new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
                },
				
				}
			}
		};

		BindingContext = viewModel;
	}
}
namespace MauiBugs.ControlTemplates;

public class GermanTemplate : VerticalStackLayout
{
	public GermanTemplate()
	{

		Children.Add(new ContentPresenter());

		Children.Add(new Label
		{
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Text = "Hello from Germany!"

		});
	}
}
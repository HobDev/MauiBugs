namespace MauiBugs.ControlTemplates;

public class IndianTemplate : VerticalStackLayout
{
	public IndianTemplate()
	{
		Children.Add(new ContentPresenter());
		Children.Add(new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Hello from India!" });


	}
}
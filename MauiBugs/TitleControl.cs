namespace MauiBugs;

public class TitleControl : ContentView
{
	public TitleControl()
	{
		Content = new VerticalStackLayout
		{
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,

            Children = {
				new Label {  Text = "Title"}
			}
		};
	}
}
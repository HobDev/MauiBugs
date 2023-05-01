
using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiBugs;

public class MainPage : ContentPage
{
	Label secondLabel;

	Label fourthLabel;
    enum BodyRow { first, second, third, fourth , fifth};
	enum BodyColumn { first, second, third };
	public MainPage(MainViewModel viewModel)
	{
		 secondLabel = new Label { Text = "I am row 2" }.Row(BodyRow.second);
	     fourthLabel = new Label { Text = "I am row 4" }.Row(BodyRow.fourth);
        Content = new Grid
		{
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			RowDefinitions = Rows.Define(
				(BodyRow.first, 20),
				(BodyRow.second, Auto),
				(BodyRow.third, 20),
				(BodyRow.fourth, 20),
				(BodyRow.fifth,40)
				),
			Children = {
				new Label {  Text = "I am row 1"}.Row(BodyRow.first),
				secondLabel,
				new Label {  Text = "I am row 3"}.Row(BodyRow.third),
				fourthLabel,
				new Button{Text="I change visibility of second and fourth rows"}.Invoke(button=>{button.Clicked+=Button_Clicked; }).Row(BodyRow.fifth)
			}


		};
BindingContext = viewModel;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		secondLabel.IsVisible = !secondLabel.IsVisible;
		fourthLabel.IsVisible = !fourthLabel.IsVisible;
    }
}
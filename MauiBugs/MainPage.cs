
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
		
        Content = new Grid
		{
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			RowDefinitions = Rows.Define(
				(BodyRow.first, 20),
				(BodyRow.second, 50)
				),
			Children = {
				new Label { }.Bind(Label.TextProperty, nameof(viewModel.Amount), stringFormat:"{0:C}").Row(BodyRow.first),
                 new Picker{ }.Bind(Picker.ItemsSourceProperty, nameof(viewModel.Amounts)).Bind(Picker.SelectedItemProperty, nameof(viewModel.Amount), stringFormat:"${0}").Row(BodyRow.second),
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
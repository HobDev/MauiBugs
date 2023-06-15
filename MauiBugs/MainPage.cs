
using CommunityToolkit.Maui.Markup;

namespace MauiBugs;

public class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		Content = new CollectionView
                {
            Margin = new Thickness(20),
            VerticalOptions =LayoutOptions.Start, 
                     HorizontalOptions=LayoutOptions.Start,
                     ItemSizingStrategy= ItemSizingStrategy.MeasureAllItems,
                    HeightRequest = 200,
                     SelectionMode = SelectionMode.Single,
                     ItemsSource=viewModel.Persons,
                     SelectionChangedCommand= viewModel.PersonChangedCommand,
                      ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
        {
            ItemSpacing = 10
        },
        ItemTemplate =new DataTemplate(() =>
        {
            return new Border
            {
                WidthRequest= 200,
                Padding=10,
                Stroke= Colors.Black,
                StrokeThickness= 1,
                Content= new Label { LineBreakMode= LineBreakMode.NoWrap}.Bind(Label.TextProperty, nameof(Person.Name))

            }.Bind(BackgroundColorProperty, nameof(viewModel.SelectedColor));

        }),
            }.Bind(SelectableItemsView.SelectedItemProperty, nameof(viewModel.SelectedPerson));

		BindingContext = viewModel;
	}
}
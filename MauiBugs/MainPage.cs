
using CommunityToolkit.Maui.Markup;

namespace MauiBugs;

public class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		Content = new VerticalStackLayout
        {
            Children = {
                 new CollectionView
                {
                     Margin= new Thickness(20,10,0,0),
                     ItemSizingStrategy= ItemSizingStrategy.MeasureAllItems,
                    HeightRequest = 60,
                     SelectionMode = SelectionMode.Single,
                     ItemsSource=viewModel.Persons,
                      ItemsLayout = new GridItemsLayout(ItemsLayoutOrientation.Horizontal)
        {
            HorizontalItemSpacing = 10
        },
        ItemTemplate =new DataTemplate(() =>
        {
            return new Border
            {
                Padding=10,
                Stroke= Colors.Black,
                StrokeThickness= 1,
                Content= new Label { LineBreakMode= LineBreakMode.NoWrap}.Bind(Label.TextProperty, nameof(Person.Name))

            };

        }),
            }
        }
        };

		BindingContext = viewModel;
	}
}
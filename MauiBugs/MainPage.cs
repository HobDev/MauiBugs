
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
                     SelectionMode = SelectionMode.Multiple,
                     ItemsSource=viewModel.Persons,
                     SelectionChangedCommand= viewModel.PersonSelectedCommand,
                     SelectedItems= viewModel.SelectedPersons,
                      ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
        {
            ItemSpacing = 10
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
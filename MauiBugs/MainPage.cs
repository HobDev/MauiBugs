
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls;

namespace MauiBugs;

public class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
        Content = new ScrollView
        {
            Content = new HorizontalStackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new VerticalStackLayout
                    {
                        Children = {
                            new CollectionView
                            {
                                HeightRequest = 110,
                                WidthRequest = 500,
                                HorizontalScrollBarVisibility = ScrollBarVisibility.Always,
                                ItemsSource = viewModel.VenueDates,
                                SelectionMode = SelectionMode.Single,
                                ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal) { ItemSpacing = 0 },
                                ItemTemplate = new DataTemplate(() =>
                                {
                                    return new Border
                                    {
                                        BackgroundColor = Color.FromArgb("#f2f2f2"),
                                        HeightRequest = 70,
                                        WidthRequest = 50,
                                        StrokeThickness = 0,
                                        StrokeShape = new RoundRectangle { CornerRadius = 8 },
                                        Content = new VerticalStackLayout
                                        {
                                            Spacing = 1,
                                            Margin = new Thickness(4),
                                            Children =
                                            {
                                                new Label { }.Bind(Label.TextProperty, nameof(VenueDate.Date), stringFormat: "{0: MMM}"),
                                                new Label { }.Bind(Label.TextProperty, nameof(VenueDate.Date), stringFormat: "{0: dd}"),
                                                new Label { }.Bind(Label.TextProperty, nameof(VenueDate.Date), stringFormat: "{0: ddd}")
                                            }

                                        }
                                    };

                                })



                            }
                        }
                    }
                }
            }
        };

		BindingContext = viewModel;
	}
}
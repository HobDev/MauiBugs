using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiBugs;

public class MainPage : ContentPage
{

    enum BodyRow { first};
    enum BodyColumn { first};
	public MainPage(MainViewModel viewModel)
	{
        DataTemplate sportTemplate = new DataTemplate(() =>
        {
            return new Border
            {
                 HeightRequest = 100,
                WidthRequest = 135,
                BackgroundColor = Color.FromArgb("#EF2F50"),


                StrokeThickness = 0,

                Content = new Grid
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,

                    RowDefinitions = Rows.Define(
                            (BodyRow.first, 90)
                            ),
                    ColumnDefinitions = Columns.Define(
                            (BodyColumn.first, 105)
                            ),

                    Children =
                    {
                        new Label{ TextColor = Colors.White, Margin=new Thickness(5,0,0,0)}.Bind(Label.TextProperty, nameof(AvailableGame.Name)),
                        new Image{HorizontalOptions=LayoutOptions.End, VerticalOptions= LayoutOptions.End, HeightRequest= 40, WidthRequest=40 , Source="dotnet_bot.png"},
                    }
                }
            };
        });

      CollectionView  collectionView = new CollectionView
        {
            SelectionMode = SelectionMode.Single,
            ItemTemplate = sportTemplate,
         ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem,
          VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Start,
         ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Horizontal)
          {
              VerticalItemSpacing = 20,
              HorizontalItemSpacing = 20,
          },
        HeightRequest = 300,
    };
      
        collectionView.Bind(ItemsView.ItemsSourceProperty, nameof(viewModel.AvailableGames));

        Padding = 20;
        Content = collectionView;
        BindingContext = viewModel;


    }
}
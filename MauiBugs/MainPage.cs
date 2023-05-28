using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiBugs;

public class MainPage : ContentPage
{
    public enum BodyRow { first, second, third, fourth, fifth, sixth}
    public enum BodyColumn { first, second, third, fourth}
    public MainPage(MainViewModel viewModel)
	{
		Content = new ScrollView
		{
            Orientation = ScrollOrientation.Both,
            HorizontalScrollBarVisibility = ScrollBarVisibility.Always,
            VerticalScrollBarVisibility = ScrollBarVisibility.Always,
            Content =new Grid
			{
                RowDefinitions = Rows.Define(
              (BodyRow.first, Auto),
              (BodyRow.second, Auto)
              ),

                ColumnDefinitions = Columns.Define(
              (BodyColumn.first, Auto),
              (BodyColumn.second, Auto),
              (BodyColumn.third, Auto),
              (BodyColumn.fourth, Auto)
              ),
                Padding= 20,
                ColumnSpacing = 20,
                RowSpacing = 20,
                Children=
                {
                    new Border{StrokeThickness= .5, Stroke= Colors.Black,  HeightRequest=1000, WidthRequest=500}.Row(BodyRow.first).Column(BodyColumn.first),
                     new Border{StrokeThickness= .5,Stroke= Colors.Black, HeightRequest=1000, WidthRequest=500 }.Row(BodyRow.first).Column(BodyColumn.second),
                      new Border{StrokeThickness= .5,Stroke= Colors.Black, HeightRequest=1000, WidthRequest=500}.Row(BodyRow.first).Column(BodyColumn.third),
                       new Border{StrokeThickness = .5,Stroke= Colors.Black, HeightRequest = 1000, WidthRequest = 500}.Row(BodyRow.first).Column(BodyColumn.fourth),
                        new Border{StrokeThickness= .5, Stroke = Colors.Black, HeightRequest = 1000, WidthRequest = 500}.Row(BodyRow.second).Column(BodyColumn.first),
                         new Border{StrokeThickness = .5, Stroke = Colors.Black, HeightRequest = 1000, WidthRequest = 500}.Row(BodyRow.second).Column(BodyColumn.second),
                          new Border{StrokeThickness = .5, Stroke = Colors.Black, HeightRequest = 1000, WidthRequest = 500}.Row(BodyRow.second).Column(BodyColumn.third),
                           new Border{StrokeThickness = .5, Stroke = Colors.Black, HeightRequest = 1000, WidthRequest = 500}.Row(BodyRow.second).Column(BodyColumn.fourth),
                }
            }
		};

		BindingContext = viewModel;
	}
}
using MauiBugs.ControlTemplates;

namespace MauiBugs;

public partial class MainPage : ContentPage
{
    Picker picker;
    int templateIndex;
    ControlTemplate indianTemplate;
    ControlTemplate germanTemplate;
    public MainPage()
    {
        InitializeComponent();
        indianTemplate = new ControlTemplate(typeof(IndianTemplate));
        germanTemplate = new ControlTemplate(typeof(GermanTemplate));
        picker = new Picker { Title = "Select Territory" };
        picker.SetBinding(Picker.ItemsSourceProperty, "TerritoryNames", BindingMode.OneTime);
        Content = picker;
        picker.SelectedIndex = 0;
        ControlTemplate = indianTemplate;
        picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
        BindingContext = new MainViewModel();
    }

    //private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = picker.SelectedIndex;
        if (index != templateIndex)
        {
            switch (index)
            {
                case 0:
                    ControlTemplate = indianTemplate;
                    break;
                case 1:
                    ControlTemplate = germanTemplate;
                    break;
                default:
                    break;
            }
        }
        templateIndex = index;
    }
}


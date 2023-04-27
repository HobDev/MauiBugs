

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiBugs
{

    public partial class MainViewModel:ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<AvailableGame> availableGames;
        public MainViewModel()
        {

            AvailableGames = new ObservableCollection<AvailableGame>
            {
                new AvailableGame {Name="Football"},
                new AvailableGame {Name="Baseball"},
                new AvailableGame {Name="Basketball"},
                new AvailableGame {Name="Golf"}
            };
            
        }

    }
}

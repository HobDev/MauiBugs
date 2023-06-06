

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiBugs
{

    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        List<Person> persons;

        public MainViewModel()
        {
            persons = new List<Person>
            {
              
                new Person{Name="Small Name"},
                 new Person{Name="This is really a large Name"},
                new Person{Name="This is Medium Name"}
            };
        }

    }
}

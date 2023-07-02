

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiBugs
{

    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        List<Person> persons;

        [ObservableProperty]
        ObservableCollection<object> selectedPersons;

        public MainViewModel()
        {
            SelectedPersons = new ObservableCollection<object>();
            Persons = new List<Person>
            {
              
                new Person{Name="Waren"},
                 new Person{Name="Bill"},
                new Person{Name="Steve"},
                new Person {Name= "William"}
            };

             Person person= Persons.FirstOrDefault();
            SelectedPersons.Add(person);
        }


        [RelayCommand]
        async Task PersonSelected()
        {
          if(SelectedPersons.Count > 0)
            {

            }
        }
    }
}

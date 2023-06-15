

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiBugs
{

    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        List<Person> persons;

        [ObservableProperty]
        Person selectedPerson;

        [ObservableProperty]
        string selectedColor;

        public MainViewModel()
        {
            persons = new List<Person>
            {
              
                new Person{Name="John"},
                 new Person{Name="Tom"},
                new Person{Name="Harry"}
            };
        }

        [RelayCommand]
        async Task PersonChanged()
        {
            if(SelectedPerson != null)
            {
                Persons.ForEach(person =>  person.SelectedColor = Colors.White);
                Person person = Persons.Where(p=>p.Name== SelectedPerson.Name).FirstOrDefault();
                person.SelectedColor= Colors.AliceBlue; 
                SelectedPerson.SelectedColor= Colors.AliceBlue;
                SelectedPerson = null;
            }
        }

    }
}

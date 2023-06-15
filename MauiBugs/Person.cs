

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiBugs
{
    public partial class Person :ObservableObject
    {
        public string Name { get; set; }

        [ObservableProperty]
        public Color selectedColor; 
    }
}

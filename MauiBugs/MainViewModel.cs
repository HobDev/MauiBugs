

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiBugs
{

    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        List<VenueDate> venueDates;

        public MainViewModel()
        {
            VenueDates = new List<VenueDate>();

            for (DateTime date = DateTime.Now; date < DateTime.Now.AddDays(89); date = date.AddDays(1))
            {
                VenueDates.Add(new VenueDate { Date = date });
            }
        }

    }
}

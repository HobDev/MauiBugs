

namespace MauiBugs
{

    public class MainViewModel
    {
        public IList<string> TerritoryNames { get; set; }
        public MainViewModel()
        {
            TerritoryNames = new List<string>();
            TerritoryNames.Add("Germany");
        }

    }
}

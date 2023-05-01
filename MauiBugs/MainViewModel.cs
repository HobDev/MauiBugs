

namespace MauiBugs
{

    public class MainViewModel
    {
       public int Amount { get; set; }  

        public IList<string> Amounts { get; set; }    
        public MainViewModel()
        {
            Amount = 100;

            Amounts = new List<string>()
            {
                "100",
                "200",
                "300",
                "400",
                "500",
            };
        }

    }
}

using OdeToFood2.Entities;
using System.Collections.Generic;

namespace OdeToFood2.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}

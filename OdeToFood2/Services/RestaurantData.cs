using OdeToFood2.ViewModels;
using OdeToFood2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood2.Services
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Tersiguel's"},
                new Restaurant { Id = 2, Name = "LJ's and the Kat"},
                new Restaurant { Id = 3, Name = "Kings Contrivance"}
            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }

}

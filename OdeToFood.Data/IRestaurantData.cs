using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant>restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
               new Restaurant{ Id=1, Name="Mikes Pizza", Location="Dids", Cuisine=Restaurant.CuisineType.Italian},
               new Restaurant{ Id=2, Name="Curry Me Flanders", Location="Springfield", Cuisine=Restaurant.CuisineType.Indian},
               new Restaurant{ Id=3, Name="Wok'n'Go", Location="Chorlotn", Cuisine=Restaurant.CuisineType.Chinese}


            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

using RestaurantInformation.Core;
using System.Linq;
using System.Collections.Generic;

namespace RestaurantInformation.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1, Name="Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
                new Restaurant{Id=2, Name="Cinnamon Club", Location="London", Cuisine=CuisineType.Mexican },
                new Restaurant{Id=3, Name="La Costa", Location="California", Cuisine=CuisineType.Mexican }
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

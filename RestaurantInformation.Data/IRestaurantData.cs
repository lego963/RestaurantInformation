using RestaurantInformation.Core;
using System.Collections.Generic;

namespace RestaurantInformation.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int? id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurants();
        int Commit();
    }
}

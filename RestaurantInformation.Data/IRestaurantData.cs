using RestaurantInformation.Core;
using System.Collections.Generic;

namespace RestaurantInformation.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetREstaurantsByName(string name);
        Restaurant GetById(int id);
    }
}

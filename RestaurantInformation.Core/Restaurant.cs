using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantInformation.Core
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(225)]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}

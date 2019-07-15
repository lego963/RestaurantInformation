using Microsoft.EntityFrameworkCore;
using RestaurantInformation.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantInformation.Data
{
    public class RestaurantInformationDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public RestaurantInformationDbContext(DbContextOptions<RestaurantInformationDbContext> options)
            : base(options)
        {

        }
    }
}

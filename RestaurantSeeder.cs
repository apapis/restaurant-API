using RestaurantAPI.Entities;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbcontext;
        public RestaurantSeeder(RestaurantDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }

        public void Seed() 
        {
            if (_dbcontext.Database.CanConnect())
            {
                if (!_dbcontext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbcontext.Restaurants.AddRange(restaurants);
                    _dbcontext.SaveChanges();
                }
            }
        
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "KFC (short for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky.",
                    ContactEmail = "contact@kfc.com",
                    ContactNumber = "+48 444 444 444",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Description = "Description",
                            Price = 10.30m
                        },
                        new Dish()
                        {
                            Name = "Chicken Nuggets",
                            Description = "Description",
                            Price = 5.30m
                        }
                    },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001"
                    }
                },
                new Restaurant()
                {
                    Name = "McDonald's",
                    Category = "Fast Food",
                    Description = "McDonald's is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald.",
                    ContactEmail = "contact@mcdonalds.com",
                    ContactNumber = "+48 444 444 444",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Big Mac",
                            Description = "Description",
                            Price = 12.50m
                        },
                        new Dish()
                        {
                            Name = "French Fries",
                            Description = "Description",
                            Price = 4.50m
                        }
                    },
                    Address = new Address()
                    {
                        City = "Warszawa",
                        Street = "Marszałkowska 10",
                        PostalCode = "00-001"
                    }
                }
            };

            return restaurants;
        }
    }
}

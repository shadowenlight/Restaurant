using System.Data.Entity;

namespace Restaurant.Models
{
    public class FoodDB : DbContext 
    { 
        public FoodDB() : base("FoodDB") { }

        public System.Data.Entity.DbSet<Restaurant.Models.Food> Foods { get; set; }
        public System.Data.Entity.DbSet<Restaurant.Models.Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Restaurant.Models.Reservation> Reservations { get; set; }
        public System.Data.Entity.DbSet<Restaurant.Models.Table> Tables { get; set; }
        public System.Data.Entity.DbSet<Restaurant.Models.Order> Orders { get; set; }
        public System.Data.Entity.DbSet<Restaurant.Models.Userr> Userrs { get; set; }
    }
}
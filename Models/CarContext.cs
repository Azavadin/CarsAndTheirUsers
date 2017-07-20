using System.Data.Entity;

namespace CarsAndTheirUsers.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
using System.Data.Entity;

namespace CarsAndTheirUsers.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Accessibility> Accessibilities{ get; set; }
    }
}
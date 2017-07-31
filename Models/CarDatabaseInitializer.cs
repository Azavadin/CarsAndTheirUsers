using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CarsAndTheirUsers.Models
{
    public class CarDatabaseInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.Users.AddOrUpdate(new User
            {
                UserName = "User1"
            },
                new User
                {
                    UserName = "User2"
                },
                new User
                {
                    UserName = "User3"
                },
                new User
                {
                    UserName = "User4"
                },
                new User
                {
                    UserName = "User5"
                },
                new User
                {
                    UserName = "User6"
                });
            context.SaveChanges();

            context.Cars.AddOrUpdate(new Car
            {
                CarName = "Car1",
            },
                new Car
                {
                    CarName = "Car2",
                },
                new Car
                {
                    CarName = "Car3",
                },
                new Car
                {
                    CarName = "Car4",
                },
                new Car
                {
                    CarName = "Car5",
                },
                new Car
                {
                    CarName = "Car6",
                });
            context.SaveChanges();

            context.Accessibilities.AddOrUpdate(new Accessibility
            {
                CarID = 1,
                UserID = 1
            },
                new Accessibility
                {
                    CarID = 1,
                    UserID = 2
                },
                new Accessibility
                {
                    CarID = 1,
                    UserID = 3
                },
                new Accessibility
                {
                    CarID = 2,
                    UserID = 1
                },
                new Accessibility
                {
                    CarID = 2,
                    UserID = 3
                },
                new Accessibility
                {
                    CarID = 3,
                    UserID = 4
                },
                new Accessibility
                {
                    CarID = 3,
                    UserID = 6
                },
                new Accessibility
                {
                    CarID = 4,
                    UserID = 1
                },
                new Accessibility
                {
                    CarID = 4,
                    UserID = 5
                },
                new Accessibility
                {
                    CarID = 5,
                    UserID = 6
                },
                new Accessibility
                {
                    CarID = 5,
                    UserID = 1
                },
                new Accessibility
                {
                    CarID = 5,
                    UserID = 2
                },
                new Accessibility
                {
                    CarID = 6,
                    UserID = 1
                },
                new Accessibility
                {
                    CarID = 6,
                    UserID = 6
                },
                new Accessibility
                {
                    CarID = 6,
                    UserID = 4
                });
            context.SaveChanges();
        }

    }
}
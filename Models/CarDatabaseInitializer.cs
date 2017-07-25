using System.Collections.Generic;
using System.Data.Entity;

namespace CarsAndTheirUsers.Models
{
    public class CarDatabaseInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            GetUsers().ForEach(user => context.Users.Add(user));
            GetCars().ForEach(car => context.Cars.Add(car));
        }

        private static List<User> GetUsers()
        {
            var users = new List<User> {
                new User
                {
                    UserID = 1,
                    UserName = "User1",
                    CarID = 1
                },

                new User
                {
                    UserID = 2,
                    UserName = "User2",
                    CarID = 2
                },

                new User
                {
                    UserID = 3,
                    UserName = "User3",
                    CarID = 3
                },

                new User
                {
                    UserID = 4,
                    UserName = "User4",
                    CarID = 4
                },

                new User
                {
                    UserID = 5,
                    UserName = "User5",
                    CarID = 5
                },

                new User
                {
                    UserID = 6,
                    UserName = "User6",
                    CarID = 6
                }

                };

            return users;
        }

        private static List<Car> GetCars()
        {
            var cars = new List<Car> {
                new Car
                {
                    CarID = 1,
                    CarName = "Car1",
                    UserID = 1
                },

                new Car
                {
                    CarID = 2,
                    CarName = "Car2",
                    UserID = 2
                },

                new Car
                {
                    CarID = 3,
                    CarName = "Car3",
                    UserID = 3
                },

                new Car
                {
                    CarID = 4,
                    CarName = "Car4",
                    UserID = 4
                },

                new Car
                {
                    CarID = 5,
                    CarName = "Car5",
                    UserID = 5
                },

                new Car
                {
                    CarID = 6,
                    CarName = "Car6",
                    UserID = 6
                }
                };

            return cars;
        }
    }
}
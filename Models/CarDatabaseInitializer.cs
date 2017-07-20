using System.Collections.Generic;
using System.Data.Entity;

namespace CarsAndTheirUsers.Models
{
    public class CarDatabaseInitializer : DropCreateDatabaseIfModelChanges<CarContext>
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
                    UserName = "Cars"
                },

                new User
                {
                    UserID = 1,
                    UserName = "Cars"
                },

                new User
                {
                    UserID = 1,
                    UserName = "Cars"
                },

                new User
                {
                    UserID = 1,
                    UserName = "Cars"
                },

                new User
                {
                    UserID = 1,
                    UserName = "Cars"
                },

                new User
                {
                    UserID = 1,
                    UserName = "Cars"
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
                    CarName = "Cars"
                },

                new Car
                {
                    CarID = 1,
                    CarName = "Cars"
                },

                new Car
                {
                    CarID = 1,
                    CarName = "Cars"
                },

                new Car
                {
                    CarID = 1,
                    CarName = "Cars"
                },

                new Car
                {
                    CarID = 1,
                    CarName = "Cars"
                },

                new Car
                {
                    CarID = 1,
                    CarName = "Cars"
                }
                };

            return cars;
        }
    }
}
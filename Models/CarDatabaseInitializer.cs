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
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 1,
                        CarName = "Car1"
                        },

                        new Car
                        {
                        CarID = 2,
                        CarName = "Car2"
                        }
                    }
                },

                new User
                {
                    UserID = 2,
                    UserName = "User2",
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 2,
                        CarName = "Car2"
                        },

                        new Car
                        {
                        CarID = 3,
                        CarName = "Car3"
                        }
                    }
                },

                new User
                {
                    UserID = 3,
                    UserName = "User3",
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 3,
                        CarName = "Car3"
                        },

                        new Car
                        {
                        CarID = 4,
                        CarName = "Car4"
                        }
                    }
                },

                new User
                {
                    UserID = 4,
                    UserName = "User4",
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 4,
                        CarName = "Car4"
                        },

                        new Car
                        {
                        CarID = 5,
                        CarName = "Car5"
                        }
                    }
                },

                new User
                {
                    UserID = 5,
                    UserName = "User5",
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 5,
                        CarName = "Car5"
                        },

                        new Car
                        {
                        CarID = 2,
                        CarName = "Car6"
                        }
                    }
                },

                new User
                {
                    UserID = 6,
                    UserName = "User6",
                    Cars = new List<Car>
                    {
                        new Car
                        {
                        CarID = 6,
                        CarName = "Car6"
                        },

                        new Car
                        {
                        CarID = 1,
                        CarName = "Car1"
                        }
                    }
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
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 1,
                        UserName = "User1",
                        },
                        new User
                        {
                        UserID = 6,
                        UserName = "User6",
                        }
                    }
                },

                new Car
                {
                    CarID = 2,
                    CarName = "Car2",
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 1,
                        UserName = "User1",
                        },
                        new User
                        {
                        UserID = 2,
                        UserName = "User2",
                        }
                    }
                },

                new Car
                {
                    CarID = 3,
                    CarName = "Car3",
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 2,
                        UserName = "User2",
                        },
                        new User
                        {
                        UserID = 3,
                        UserName = "User3",
                        }
                    }
                },

                new Car
                {
                    CarID = 4,
                    CarName = "Car4",
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 3,
                        UserName = "User3",
                        },
                        new User
                        {
                        UserID = 4,
                        UserName = "User4",
                        }
                    }
                },

                new Car
                {
                    CarID = 5,
                    CarName = "Car5",
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 4,
                        UserName = "User4",
                        },
                        new User
                        {
                        UserID = 5,
                        UserName = "User5",
                        }
                    }
                },

                new Car
                {
                    CarID = 6,
                    CarName = "Car6",
                    Users = new List<User>
                    {
                        new User
                        {
                        UserID = 5,
                        UserName = "User5",
                        },
                        new User
                        {
                        UserID = 6,
                        UserName = "User6",
                        }
                    }
                }
                };

            return cars;
        }
    }
}
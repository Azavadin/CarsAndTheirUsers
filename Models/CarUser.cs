namespace CarsAndTheirUsers.Models
{
    public class CarUser
    {
        public int CarID { get; set; }
        public Car Car { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
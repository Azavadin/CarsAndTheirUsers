namespace CarsAndTheirUsers.Models
{
    public class CarUserBridge
    {
        public int CarUserBridgeID { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
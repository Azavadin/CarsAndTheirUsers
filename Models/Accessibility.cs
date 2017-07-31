using System.ComponentModel.DataAnnotations;

namespace CarsAndTheirUsers.Models
{
    public class Accessibility
    {
        [Key]
        public int AccessibilityID { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }

        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}
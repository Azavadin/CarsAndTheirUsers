using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarsAndTheirUsers.Models
{
    public class User
    {
        public User()
        {
            Cars = new HashSet<Car>();
        }

        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string UserName { get; set; }

        public int CarID { get; set; }

        //public virtual ICollection<Car> Cars { get; set; }
    }
}
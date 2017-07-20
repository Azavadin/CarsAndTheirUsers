using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarsAndTheirUsers.Models
{
    public class Car
    {
        [ScaffoldColumn(false)]
        public int CarID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CarName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
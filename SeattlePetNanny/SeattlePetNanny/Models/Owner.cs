using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeattlePetNanny.Models
{
    public class Owner :IdentityUser
    {
        [Key]
        public int OwnerID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // [DataType(DataType.Date)]
        // public DateTime Birthday { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        //public blob Photo { get; set; }

        public List<Dog> Dogs { get; set; }
    }
}

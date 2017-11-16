using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }
        // secondary items needed, the rest of the Owner information is stored in AppplicationUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        // future implementation for photo storage
        // public blob Photo { get; set; }

        // the id of the corresponding user in the ApplicationUser database
        public int UserID { get; set; }
        // list of the dogs attached to this user
        public virtual ICollection<Dog> Dogs { get; set; }
    }
}

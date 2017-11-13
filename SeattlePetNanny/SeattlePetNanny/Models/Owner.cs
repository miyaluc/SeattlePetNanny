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
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public blob Photo { get; set; }

        [Required]
        public int DogID { get; set; }
        public virtual Dog Dog { get; set; }
    }
}

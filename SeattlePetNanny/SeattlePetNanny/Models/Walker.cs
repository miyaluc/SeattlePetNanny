using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class Walker
    {
        [Key]
        public int WalkerID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public blob Photo { get; set; }
        //public List<DateTime> Schedule { get; set; }
    }
}

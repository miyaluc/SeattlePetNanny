using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class Worker
    {
        [Key]
        public int WorkerID { get; set; }
        // secondary items needed, the rest of the Owner information is stored in AppplicationUser
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Neighborhood { get; set; }
        // future implementation for photo storage
        // public blob Photo { get; set; }

        // the id of the corresponding user in the ApplicationUser database
        public int UserID { get; set; }
        // future implementation for schedule
        // public List<DateTime> Schedule { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class Dog
    {
        [Key]
        public int DogID { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public int Temperment { get; set; }
        //public blob Photo { get; set; }

        public int OwnerNumber { get; set; }
        public Owner Owner { get; set; }

        //public List<ReportCard> ReportCard { get; set; }
    }
}

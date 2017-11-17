using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class DogViewModel
    {      
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Temperment { get; set; }
    }
}

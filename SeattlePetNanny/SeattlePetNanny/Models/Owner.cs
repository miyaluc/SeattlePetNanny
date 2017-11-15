﻿using System;
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
        public int UserID { get; set; }
        public string Location { get; set; }
        //public blob Photo { get; set; }

        public List<Dog> Dogs { get; set; }
    }
}

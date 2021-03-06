﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Models
{
    public class ReportCard
    {
        [Key]
        public int ReportCardID { get; set; }
        public string Report { get; set; }
        public string OwnerNotes { get; set; }
        public string WorkerNotes { get; set; }

        public int DogID { get; set; }
        public virtual Dog Dog { get; set; }
    }
}

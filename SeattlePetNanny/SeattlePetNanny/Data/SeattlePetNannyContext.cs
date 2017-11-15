using Microsoft.EntityFrameworkCore;
using SeattlePetNanny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Data
{
    public class SeattlePetNannyContext : DbContext
    {
        public SeattlePetNannyContext(DbContextOptions<SeattlePetNannyContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owner { get; set; }

        public DbSet<Dog> Dog { get; set; }

        public DbSet<Worker> Worker { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<ReportCard> ReportCard { get; set; }

    }
}

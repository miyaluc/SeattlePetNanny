using Microsoft.EntityFrameworkCore;
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

        public DbSet<Models.Owner> Owner { get; set; }

        public DbSet<Models.Dog> Dog { get; set; }

        public DbSet<Models.Worker> Worker { get; set; }

        public DbSet<Models.Admin> Admin { get; set; }

        public DbSet<Models.ReportCard> ReportCard { get; set; }

    }
}

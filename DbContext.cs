using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PracticeEntiry.Models;

namespace PracticeEntiry
{
    public class DtbaseContext:DbContext
    {
        public DbSet<Countries>  Countries{ get; set; }
        public DbSet<Partipicants> Partipicants { get; set; }
        public DbSet<Medals> Medals { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<PartMedals> PartMedals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OlympycGames;Integrated Security=true;");
        }
    }
}

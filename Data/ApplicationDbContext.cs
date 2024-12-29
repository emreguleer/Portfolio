using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "IsEmirleri" },
                new Project { Id = 2, Name = "CrawlProject" },
                new Project { Id = 3, Name = "NazmiGelenAgency" }
                );
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "C#" },
                new Skill { Id = 2, Name = "EntityFramework Core" },
                new Skill { Id = 3, Name = "LINQ" },
                new Skill { Id = 4, Name = "ASP.Net Core" },
                new Skill { Id = 5, Name = "SQL" },
                new Skill { Id = 6, Name = "Mssql" },
                new Skill { Id = 7, Name = "MongoDB" },
                new Skill { Id = 8, Name = "Elasticsearch" }
                );
        }
    }
}

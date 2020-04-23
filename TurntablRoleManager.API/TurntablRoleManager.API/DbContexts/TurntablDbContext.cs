using TurntablRoleManager.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace TurntablRoleManager.API.DbContexts
{
    public class TurntablDbContext : DbContext
    {
        public TurntablDbContext(DbContextOptions<TurntablDbContext> options)
           : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
       /* public DbSet<Course> Courses { get; set; }*/

      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Name = "Developer",
                    Description = "Devloping and Managing Application",
                    CreatedAt = new DateTime(1650, 7, 23),
                    
                },
                new Role()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Name = "Project Manager",
                    Description = "Maninging project for the company",
                    CreatedAt = new DateTime(1650, 7, 29),
                },
                new Role()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Name = "Accountant",
                    Description = "Maninging accounts for the company",
                    CreatedAt = new DateTime(1701, 12, 16)
                }
                
                );

         
            base.OnModelCreating(modelBuilder);
        }*/
    }
}

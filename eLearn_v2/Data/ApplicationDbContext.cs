using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using eLearn_v1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region CourseSeed

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Name = "Introduction To Programming",
                Description = "This course is about programming languages and bascis in Fundamental ....",
                Rating = 4,
                Image="programming.png"
          
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Name = "Introduction To Programming",
                Description = "This course is about programming languages and bascis in Fundamental ....",
                Rating = 10,
                Image = "programming.png"


            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 3,
                Name = "Introduction To Programming",
                Description = "This course is about programming languages and bascis in Fundamental ....",
                Rating = 2,
                Image = "programming.png"

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 4,
                Name = "Introduction To Programming",
                Description = "This course is about programming languages and bascis in Fundamental ....",
                Rating = 7,
                Image = "programming.png"


            });


            #endregion
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Student { get; set; }
       
    }
}

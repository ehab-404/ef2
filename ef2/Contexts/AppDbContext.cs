using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ef2.Configurations;
using ef2.Entities;
using Microsoft.EntityFrameworkCore;

namespace ef2.Contexts
{
    internal class AppDbContext:DbContext
    {




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.Entity<Department>().HasOne(d=>d.Manager).WithOne(e=>e.Department)
                .HasForeignKey<Department>().HasForeignKey<Department>(d=>d.Manager);


            modelBuilder.Entity<Department>().HasMany(d => d.Employees).WithOne(e => e.WorkFor)
                .HasForeignKey(e => e.WorkForId);


            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.CourseId, sc.StudentId });




            base.OnModelCreating(modelBuilder);
        }



        public AppDbContext() : base() { } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server =DESKTOP-Q6ECCSC\\SQLEXPRESS01; Database = AppG03; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Employee> Employees { get; set; } 

        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }




       

    }



}

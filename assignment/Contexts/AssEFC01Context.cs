using Microsoft.EntityFrameworkCore;
using assignment.Entities;
using Ass_EFC01.Configurations;

namespace Ass_EFC01.Contexts
{
    public class AssEFContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        public AssEFContext() : base() { } // constructor

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server =DESKTOP-Q6ECCSC\\SQLEXPRESS01; Database = ass; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.Entity<Stud_Course>().HasKey(k => new { k.Course_ID, k.stud_ID });
            modelBuilder.Entity<Course_Inst>().HasKey(k => new { k.Course_ID, k.inst_ID });
        }
    }
}

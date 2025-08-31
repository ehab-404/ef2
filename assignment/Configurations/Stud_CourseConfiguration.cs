using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using assignment.Entities;

namespace Ass_EFC01.Configurations
{
    public class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Course");
            builder.HasKey(e => new { e.stud_ID, e.Course_ID });
            builder.Property(e => e.Grade).HasColumnType("decimal(5,2)");
        }
    }
}
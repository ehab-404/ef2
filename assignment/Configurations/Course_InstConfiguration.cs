using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using assignment.Entities;

namespace Ass_EFC01.Configurations
{
    public class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Course_Inst");
            builder.HasKey(e => new { e.inst_ID, e.Course_ID });
            builder.Property(e => e.evaluate).HasMaxLength(100);
        }
    }
}
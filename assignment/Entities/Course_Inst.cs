using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Course_Inst
    {
        [InverseProperty(nameof(inst.ID))]
        public int inst_ID { get; set; }
        public Instructor inst { get; set; }

        [InverseProperty(nameof(Course.ID))]
        public int Course_ID { get; set; }

        public Course Course { get; set; }
        public string evaluate { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Stud_Course
    {

        public Student Student { get; set; }
        [InverseProperty(nameof(Student.ID))]
        public int stud_ID { get; set; }


          public Course Course { get; set; }
        [InverseProperty(nameof(Course.ID))]
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public int? Bounus { get; set; }
        public decimal Salary { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public decimal HourRateBouns { get; set; }
        [InverseProperty(nameof(Department.ID))]
        public int Dept_ID { get; set; }
        public Department WorkIn { get; set; }
    }
}
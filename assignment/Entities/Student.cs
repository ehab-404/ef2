using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [InverseProperty(nameof(Department.ID))]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
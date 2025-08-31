using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Entities
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [InverseProperty(nameof(Instructor.ID))]
        public int ManagerID { get; set; }

        public Instructor Manager { get; set; }

        public DateTime HiringDate { get; set; }
    }
}
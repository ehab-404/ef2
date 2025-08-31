using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef2.Entities
{
    internal class StudentCourse
    {

      //by convention when property name is table name + pk of this table  it will be for this table
      //instead of making navigation property + fk make prop of name= table name+pk of it 

       public int StudentId { get; set; }

       // [InverseProperty(nameof(Student.Id))]
       //public Student Student { get; set; }

        public int CourseId { get; set; }
        public int Grade  { get; set; }


    }
}

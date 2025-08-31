using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef2.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public int Age {  get; set; }

        //many - many  mandatory
        //ef will auto generate third table but  if relationship attributes then you must
        //generate the third table manually 
        public List<Course> Courses { get; set; }




        


    }
}

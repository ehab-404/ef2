using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef2.Entities
{
    

    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public int? Salary { get; set; }
        public string Address { get; set; }

        public DateTime DateOfCreation { get; set; }

        [InverseProperty(nameof(Department.Id))] // to make fk and detect referenced property 

      public Department Department { get; set; }

        //c# ignore 1-1 ,1-m ,m-m  c# see that table has navigation property
        //to single object or list of objects or not

        //one employee has one department 
        // ?  mean optional not mandatory 
        //fk prop  to solve proplem of loading 
        public int? WorkForId { get; set; }
        public Department? WorkFor { get; set; }




    }













}

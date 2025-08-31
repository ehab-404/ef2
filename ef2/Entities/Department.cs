using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef2.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }


        #region 7 one to one 




        //one to one relationship between department and employee 
        //navigation property    : table has reference for object of type of other table 

        public Employee Manager { get; set; }


        //you can add property to access pk of navigation instance like fk 


      //  [ForeignKey(nameof(Department.Manager))]  //name of navigation property  
        public int? ManagerId { get; set; }
        //by convention :  name of navigation property + pk name of navigation property
        //translated to fk of navigation property  in db 



        //c# ignore 1-1 ,1-m ,m-m  c# see that table has navigation property
        //to single object or list of objects or not

        //one department has many employees 
        public List<Employee>? Employees { get; set; }


        #endregion
    }
}

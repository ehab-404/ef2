using ef2.Contexts;
using ef2.Entities;
using Microsoft.EntityFrameworkCore;

namespace ef2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2 prepare for crud operations 



            //create read update delete  on specified db using the bridge of it  "dbcontext"

            //AppDbContext db = new AppDbContext(); //create then configure
            //configuration will start connection that use ram 


            //after finishing close the connection 

            //db.Dispose();

            //try {
            //    //crud code


            //}
            //finally { 


            //    db.Dispose(); 


            //}


            //using (AppDbContext db = new AppDbContext() /* unmanaged source*/)
            //    //syntax sugar for try finally  , bydefault will close the source
            //{

            //    //crud

            //}

            using AppDbContext db = new AppDbContext();  //syntax sugar for dealing with unmanaged source

            




            #endregion


            #region 3 create

            var employee = new Employee()
            {
                Name = "ehab",
                Salary = 12000,
                Address = "zagazig",
                Age = 25,
                Email="popehab@gma"


            };


            Console.WriteLine(db.Entry(employee).State);
            //deattached only in ram but not in db or tracked by context 

            //db.Employees.Add(employee);
            db.Entry(employee).State = EntityState.Added; //same behaviour of Add() method 

            Console.WriteLine(db.Entry(employee).State);
            //added ,tracked in context but not saved in db  

        var result=  db.SaveChanges();
            //apply all changes of dbcontext on db 

            Console.WriteLine(db.Entry(employee).State); 
            //unchanged  , compare obj in context , db 


            
            
            Console.WriteLine(result);
            //1   
            //0 => de attached  1=>unchanged     2=>deleted   3=>modified  4=> added 


            employee.Name = "pop";
            Console.WriteLine(db.Entry(employee).State);
            //modifieded  tracked by context , in db but some differences 




            db.SaveChanges();
            Console.WriteLine(db.Entry(employee).State);
            //unchanged  , compare obj in context , db  




            #endregion

            #region 4read 
            //read -retrieve 
            //var result_employee = db.Employees.Where(e => e.EmpId == 40).FirstOrDefault();
            var result_employee = db.Employees.FirstOrDefault(e => e.Id == 1);
            var result_employees = db.Employees;
            
            foreach(var e in result_employees)
            {
                Console.WriteLine(e.Name);

            }

            var result_employees_names = db.Employees.Select(e => e.Name);
            foreach(var e in result_employees_names)
            {

                Console.WriteLine(e);
            }


            Console.WriteLine(result_employee?.Name);
            #endregion


            #region 5 update

            //update  db.Employees.Update()


            var result5 = db.Employees.FirstOrDefault(e => e.Id == 1);

            Console.WriteLine(db.Entry(result5).State);//unchanged 

            result5.Name = "pepo";

            Console.WriteLine(db.Entry(result5).State);//modified

            db.Update(result5);

            db.SaveChanges(); 
            Console.WriteLine(db.Entry(result5).State); // unchanged 



            #endregion



            #region 6 delete

          var result6= db.Employees.FirstOrDefault();

            Console.WriteLine(db.Entry(result6).State);//unchanged 
            db.Employees.Remove(result6); //only removed in context

            Console.WriteLine(db.Entry(result6).State);//deleted

            //state property of entry : for making savechanges method to apply behaviour of this state in db 

            db.SaveChanges();

            Console.WriteLine(db.Entry(result6).State);//deattached 






            #endregion

        }
    }

}

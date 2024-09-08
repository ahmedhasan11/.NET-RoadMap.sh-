using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaex_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeEntities entities=new EmployeeEntities();
            Emp emp = new Emp();
            emp.empno = 5664;
            emp.nam = "ahmed";
            emp.desig = "aaaa";
            entities.Emps.Add(emp);
            entities.SaveChanges();
        }
    }
}

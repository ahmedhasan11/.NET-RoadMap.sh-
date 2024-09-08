using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_with_databases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeEntities entities = new EmployeeEntities();
            var res1 = from em in entities.Emps select em;
            foreach(var i in res1 )
            {
                Console.WriteLine(i.empno);
            }
            
            
        }
    }
}

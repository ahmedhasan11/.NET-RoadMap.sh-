using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaex_database
{
    internal class lambdasearch
    {

        static void main(string[] args)
        {
            EmployeeEntities entities = new EmployeeEntities();
            int empno = 1;
            Emp result = entities.Emps.Select(x => x).Where(x => x.empno == empno).FirstOrDefault<Emp>();
            Console.WriteLine(result.nam);


        }

    }

}    


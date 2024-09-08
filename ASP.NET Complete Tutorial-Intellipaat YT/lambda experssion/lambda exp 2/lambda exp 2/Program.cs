using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_exp_2
{
    internal class Program
    {
        class emp
        {
            public int empno { get; set; }
            public int desig { get; set; }
            public string nam { get; set; }
        }
        static void Main(string[] args)
        {
            List<emp> employee = new List<emp>()
            {
                new emp{ empno =1 , desig=3 ,nam="dd"},
                new emp{empno =3 , desig=2 ,nam="aa"}
            };
            // var result1 = from i in employee select i;
            var result1 = employee.Select(x => x);

            foreach (var i in result1)
            {
                Console.WriteLine(i.empno);
            }

            var result2=employee.Select(x => new {x.empno ,x.nam, x.desig}); //projected data
            foreach (var i in result2)
            {
                Console.WriteLine(i.empno +"" + i.nam +"" + i.desig);
            }

            var result3 = employee.Select(x => x).Where(x=>x.desig.Equals(2)); //compare data
            foreach (var i in result3)
            {
                Console.WriteLine(i.empno + "" + i.nam + "" + i.desig);
            }

            var result4 = employee.Select(x => x).Where(x=> x.desig >=6000); //desig>6000 
            foreach (var i in result4)
            {
                Console.WriteLine(i.empno + "" + i.nam + "" + i.desig);
            }

            var result5 = employee.Select(x => x).OrderBy(x=>x.empno); //sorted data ascending
            foreach (var i in result5)
            {
                Console.WriteLine(i.empno + "" + i.nam + "" + i.desig);
            }

            var result6 = employee.Select(x => x).OrderByDescending(x => x.empno); //sorted data decsending
            foreach (var i in result6)
            {
                Console.WriteLine(i.empno + "" + i.nam + "" + i.desig);
            }







            Console.ReadKey();
        }
    }
}

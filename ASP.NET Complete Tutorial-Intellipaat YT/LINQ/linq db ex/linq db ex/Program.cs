using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linq_db_ex
{

    class emp
    {
        public int empno {  get; set; }
        public string nam {  get; set; }
        public int desig {  get; set; }
        public string dept { get; set; }
    }

    class depts
    {

        public string branch {  get; set; }
        public string city {  get; set; }

        public string dept {  get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeEntities entities = new EmployeeEntities();
            var result1 = from em in entities.Emps select em;
            foreach(var i in result1)
            {
                Console.WriteLine(""+i.nam );
            }

            var result2 = from em in entities.Emps //projected data
                          select new
                          {
                              em.empno,
                              em.nam,
                              em.desig
                          };
            Console.WriteLine("projected data");

            foreach(var i in result2)
            {
                Console.WriteLine("" + i.empno+""+i.nam + i.desig);
            }

            var result3 = from em in entities.Emps where em.empno >= 0 select em; //filtered records

            foreach (var i in result3)
            {
                Console.WriteLine("" + i.empno + "" + i.nam + i.desig);
            }

            var result4 = from em in entities.Emps orderby em.empno select em; //sorted records

            foreach (var i in result4)
            {
                Console.WriteLine("" + i.empno + "" + i.nam + i.desig);
            }

            //using join
            List<emp> Employee = new List<emp>()
            {
                new emp{empno= 1 , nam="aaaa" , desig = 3 , dept="dddddddddd"},
                new emp{empno= 2 , nam="dddd" , desig = 4 , dept="dddddddddd"}


            };
            List<depts> dept = new List<depts>()
            {
                new depts{dept="aaaaaaaa" , branch="bbbbbb" , city="cccccccccc"},
                new depts{dept="dddddddddd" , branch="eeeeeeee" , city="fffffffffff"}
            };

            Console.WriteLine("join data");
            var result5 = from em in Employee
                          join dp in dept on  em.dept equals dp.dept
                          select new
                          {
                              em.empno,em.nam,em.desig,
                              dp.branch, dp.city
                          };
            foreach (var i in result5)
            {
                Console.WriteLine("" + i.empno + "" + i.nam + i.desig);
            }




        }

    }
}

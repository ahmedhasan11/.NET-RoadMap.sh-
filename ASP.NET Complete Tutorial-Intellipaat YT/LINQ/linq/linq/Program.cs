using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employ> employList = new List<employ>()
            {
                new employ{empno=1,nam="aa" , desig="vvbb"},
                new employ{empno=2,nam="dd" , desig="vvcccc"}

            };

            var result = from em in employList select em;
            Console.WriteLine("result is:");
            foreach(var i in result)
            {
                Console.WriteLine(i.empno+ "" + i.nam + "" + i.desig);
            }

            var result1 = from em in employList where em.nam.Equals("aa") select em;

            foreach(var d in result1){
                Console.WriteLine(""+d.nam +"" +d.empno + "" + d.desig);

            }

            var result2 = from em in employList orderby em.empno select em;

            Console.ReadKey();
        }
    }
}

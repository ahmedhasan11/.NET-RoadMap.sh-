using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            //var res2 = from p in x select p;
            var res1 = x.Select(p => p);
            foreach(var v in res1)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}

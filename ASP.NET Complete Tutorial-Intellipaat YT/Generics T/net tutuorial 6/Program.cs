using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_tutuorial_6
{
    internal class Program
    { //we are doing generics
        class demo
        {
            public void swap <T>(ref T a , ref T b)  //T here is a something acting like a datatype , so it check the value u give and assign it , if double then T is double and so on
            {
                T t;
                t = a;
                a=b;
                b=t;
            }
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 15;
            demo obj = new demo();
            Console.WriteLine("{0}{1}" ,  a , b);

            double d1 = 12.5;
            double d2 = 13.5;
            obj.swap(ref d1, ref d2);
            Console.WriteLine("{0}{1}" , d1, d2);
        }
    }
}

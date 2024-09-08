using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nett_utorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            double y = 12.5;
            string name = "vikas";

            //boxing
            object obj1 = x;
            object obj2 = y;
            object obj3 = name;

            //unboxing
            int x1 = (Int32)obj1;
            double y1 = (Double)obj2;
            string s1 = (string)obj3;
        }

    }
}

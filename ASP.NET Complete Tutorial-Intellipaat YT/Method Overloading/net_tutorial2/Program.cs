using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace net_tutorial2
{
    internal class Program
    {
        //method overloading

        public void show(int x)
        {
            Console.WriteLine("");
        }
        public void show(double x)
        {
            Console.WriteLine("");
        }
        public void show(string x)
        {
            Console.WriteLine("");
        }

        //method overloading 2
        public int sum(int x )
        {
            Console.WriteLine("");
            return x;
        }
        public int sum(int x , int y)
        {
            Console.WriteLine("");
            return x & y;
        }
        public int sum(int x , int y , int z)
        {
            Console.WriteLine("");
            return x & y & z;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //method overloading
            obj.show(12);
            obj.show(12.2);
            obj.show("aaa");
            //method overloading 2
            obj.sum(10);
            obj.sum(10, 20);
            obj.sum(10, 20, 30);


        }


    }
}

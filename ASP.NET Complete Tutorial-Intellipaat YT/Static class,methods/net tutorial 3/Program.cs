using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_tutorial_3
{

    static class test //static class , must have static methods
    {
        public static void greeting()
        {
            Console.WriteLine("");
        }
        public static void dodododo()
        {
            Console.WriteLine("");
        }

    }
    class data
    {
        public void show()
        {
            Console.WriteLine("");
        }
        public static void display()  //static method , called by using class name
        {
            Console.WriteLine("");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            data obj = new data();
            obj.show();

            data.display(); //static method , called by using class name
        }
    }
}

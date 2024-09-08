using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have to add system.collections so we can use the arraylist keyword

            //declare 1 with undefined amount of objects
            ArrayList myarraylist=new ArrayList();

            //declare 2 with defined amount of objects
            ArrayList myarraylist2 = new ArrayList(100);

            myarraylist.Add(25);
            myarraylist.Add("hello");
            myarraylist.Add(13.37);
            myarraylist.Add(13);
            myarraylist.Add(128);
            myarraylist.Add(25.3);
            myarraylist.Add(13);

            //delete element with specific value from the arraylist
            myarraylist.Remove(13); // if we have another value called 13 in the list , it will not be romoved , this gonna remove the first 13 in the list

            //delete element at a specific position (index)
            myarraylist.RemoveAt(0);

            //how many objects inside you arraylist
            Console.WriteLine(myarraylist.Count);

            double sum = 0;

            foreach(object obj in myarraylist)
            {
                if (obj is int) //it contains an integer , but the obj is object datatype
                {
                    sum += Convert.ToDouble(obj); //we made the convert.todouble because the sum is a double 
                }
                else if (obj is double) //it contains a double , but the obj is object datatype
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);

        }
    }
}
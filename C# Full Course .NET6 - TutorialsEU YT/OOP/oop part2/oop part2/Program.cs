using oop_part2;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           box boxx=  new box();
            /*when the variables was public in the box class , so we could access them directly with . syntax , but public variables cause security problems,
            so we made the variables in box class all private and we gave them a value there , so any box object that we will create in the class program will 
            take the values that we assigned in the box class , so we are not accessing the variables of box class directly*/
            boxx.length = 10;
            /*the problem now that what if we want to access length variable and print it for an example , we cant access it directly , we cant
                just say box.length , we cant do that , so solution here is to make a method in the box class that do the thing that we want
                 and just call that method in the main method in class program with its object , so we use "set method*/ 
            boxx.setlength(-1);
            //but , what can we do if we really need ot access the length variable directly from the box class , we will use something called "get method"
            Console.WriteLine("box length is {0}" , boxx.getlength());
            /*so what we learned here is that u shouldn't give access directly to a variable , instead we gave access to a method that can adjust 
             this variable , and we decie how we need to pass these values or how to pass them */



            boxx.height = 10;
            //we cant access the height variable because its private , but we can access the property of Height that we have made
            boxx.Height = 10; //the "10" here gonna be the "value" keyword that we talked about in the box class


            boxx.width = 10;
            boxx.displayinfo();         
        }
    }
}

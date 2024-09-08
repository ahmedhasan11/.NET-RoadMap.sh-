using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*to call the writesomething method in main , the method that u are calling should be static too
            like the main method*/
            writesomethin();

            Console.WriteLine("please enter a num");
            string input= Console.ReadLine();


            /*here we used the try catch because if a user entered something like "aaaaaaaaaaaaaa" so thats a char or
            string precisely , so an error will be happen when we try to ((int.parse a string)) so if the user entered
            a num so thats it and result will happen , if user entered anything not a num . an exception will be thrown*/
            try
            {
                int userinput=int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception please enter the correst type next time");
            }



            /* here we made another exception for the obverflow which mean that if user entered a very big number like 11
             11111111111111111111111111111111111 so thats so big for a string to store or to handle
            , so an error will be happen*/
            catch (OverflowException)
            {
             Console.WriteLine("enter a smaller number next time");
            }



            /* here we used another catch for if the user didnt enter a value and he just pressed enter , so an
             exception will be thrown with argument null exception or whatever u said*/
            catch(ArgumentNullException) 
            {
                Console.WriteLine("value is empty , please put a value");
            }




            /* here Finally keyword is used when u want the window to print something whatever and exception happened or not */
            finally 
            {
                Console.WriteLine("this will be done anyways");
            }

            
        }
        public static void writesomethin()
        {
            Console.WriteLine("iam called for a method");
        }
        public static void writesomethingspecific(string mytext) 
        {
        Console.WriteLine(mytext);
        }
    }
}


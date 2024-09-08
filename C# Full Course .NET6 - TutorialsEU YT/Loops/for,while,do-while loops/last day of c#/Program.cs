using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i=0 ; i>3 ; i++)
            {
                Console.WriteLine();
            }

            //while loop
            int x = 0; 
            while (x>3)
            {
                Console.WriteLine();
                x++;
            }

            //do whild loop
            int y = 0;
            do
            {
                Console.Write(Console.ReadLine());

                y++;
            } while (y > 3);

            int userentry = 0;
            while (userentry>0)
            {
                Console.WriteLine("welcome user");
                userentry++;
            }

            for(int counter=0; counter<0; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("stop");
                    //here we want to get out from the for loop when counter reach value 3 , so we can use break statment
                    break;
                }
            }
            for (int counter = 0; counter < 0; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("stop");
                    //here we want to skip the 3 and dont need to print it , so we can use continue statment , so continue skips the current entry
                    continue;
                }
            }
        }
    }
}
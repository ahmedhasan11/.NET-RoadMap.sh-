using System;

namespace ahmefg
{
    class program
    {
        static void Main(string[] args)
        {
            //this is the normal parsing
            //string numberasastring = Console.ReadLine();

           //int parsedvalue= int.Parse(numberasastring);

            /*there is a method callled tryparse method, its like parsing a string to an integer when we get input from user ,u can make it int-float-double*/
            string test= Console.ReadLine();
            int parsed;
            bool success= int.TryParse(test, out parsed); //here we tell him to parse the test var as an integer and then store the value in parsed var
            /*the result of the tryparse method is always a boolean , so always a true or false , i the parsing have been one or not
             , so we can use it in if statements with conitions that if the bool was true so make something , an if bool was false so o another thing*/

            if (success)
            {
                Console.WriteLine("parsing done");
            }
            else
            {
                Console.WriteLine("a problem happene in parsing");
            }





        }
    }
}

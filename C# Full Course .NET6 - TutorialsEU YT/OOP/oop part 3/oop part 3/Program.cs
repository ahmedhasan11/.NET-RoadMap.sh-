using oop_part_3;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            members ahmed = new members();
            ahmed.Introduceyourself(true); //what we did here that we called the introduce method that is "public" so we can call it
            //and when you see the code of the public method in the members class , u find that we are calling the sharingprivate method that is "private"
            //so thats a way that if u had to make a method private , so u can call her in a public method , and call that public method directly
        }
    }
}

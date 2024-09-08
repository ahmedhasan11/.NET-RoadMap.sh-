using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case___if_shortcut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //remember the switch case syntax
            int age = 25;
            switch (age)
            {
                case 25:
                    Console.WriteLine("nice age");
                    break;
                case 24:
                    Console.WriteLine("");
                    break;
                //default is action that gonna be happen is there is no case is true , like else in if statments
                default:
                    Console.WriteLine("");
                    break;
            }
            string stateofmatter;
            int temprature = 5;
            //shortcut for if statments is --------- stateofmatter= temprature < 0 ? "solid" : "liquid" -----this means that check the condition that
            // stateofmatter= temprature < 0 , if its true so o the first action after the ? sign , if condition is flase do the second action

            stateofmatter = temprature < 0 ? "solid" : "liquid";

            /*there is a shortcut too for the nested if else statements , here it check the condition , if its true so it complete the first action 
             , if its flase , it will go to the second action that is already a if shortcut statment, so it check the second condition now and if 
            its true it complete the first action from the second condition , if flase it do the second action for the second condition*/
            stateofmatter = temprature > 100 ? "gas" : temprature < 0 ? "solid" : "liquid";
        }
    }
}

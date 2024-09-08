using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Human
    {
        //member variable
         private string FirstName;
        private string LastName;
        private string eyecolor;
        private int age;

        //member method
        public void introducemyself()
        {
            if (age!=0 && eyecolor!=null && FirstName!=null && LastName != null)
            {
                Console.WriteLine("hi iam {0} {1} {2} {3}", FirstName, LastName, eyecolor, age);
            }
            else if ( FirstName != null && LastName != null)
            {
                Console.WriteLine("hi iam {0} {1}", FirstName, LastName);
            }
            
            
        }

        // Parameterized constructor        , it has the same name of the class , it doesn't have a return type
        public Human(string myFirstName,string LastName, string eyecolor, int age)  //in parameters here u put the parameters that u want to have each time u make an object
        {
            //now we want to assign the parameters than the object will send , we want to store them to our public fn,ln u there

            FirstName = myFirstName; //way n1 , better to use when we can change the parameter name and it doesnt have same name of the public variable
            this.LastName = LastName; //way n2 , better to use when we have to make the parameter have the exact name of the public variable
            this.eyecolor = eyecolor;
            this.age = age;

            /* now after we made the constructor , we don't have to make the fn,ln public , we can now make them private , because now 
                we didnt try to access at the fn,ln variables clearly , we now access them by the way of the public constructor */
        }
        //default Constructor
        public Human()
        {
            Console.WriteLine("zzzzzzzzzzzz");
        }

        public Human(string myFirstName,string LastName)
        {
            FirstName=myFirstName;
            this.LastName=LastName;
        }
        public Human(string myFirstName)
        {
            FirstName = myFirstName;
        }

    }
}

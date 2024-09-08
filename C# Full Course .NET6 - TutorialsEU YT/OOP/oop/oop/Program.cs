using oop;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
       /*here we was accessing the variables clearly from another class so we had to make these variables public */

            /* this is how to create an object of your class , or and instance of human */
            //    Human denis=new Human(,);
            //    Human ahmed =new Human();
            //    Human eslam =new Human();

            /* access public variable from outside,change it */
            //    denis.FirstName = "denis";
            //    denis.LastName = "ahmed";
            //    ahmed.FirstName = "ahmed";
            //    ahmed.LastName = "hasan";
            //    eslam.FirstName = "eslam";
            //    eslam.LastName = "hasan";
            /* all above sentences was before we made a constructor */


            /* after we used a constructor so we dont need all of these sentences that we wrote */

            /* now after we made the constructor , we don't have to make the fn,ln public , we can now make them private , because now 
             we didnt try to access at the fn,ln variables clearly , we now access them by the way of the public constructor */
            Human denis = new Human("denis","ahmed","brown",20);
            Human ahmed =new Human("ahmed","hasan", "brown",30);
            Human eslam =new Human("eslam","hasan", "brown",40);
            Human amira = new Human();

            /* call methods of the class */
            denis.introducemyself();
            ahmed.introducemyself();
            eslam.introducemyself();
            amira.introducemyself();
        }
    }
}

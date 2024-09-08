using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop_part_3
{
    internal class members
    {
        //mmeber private field
        private string membername;
        private int salary=2000;

        private string jobtitle;
         //member public fields

        public int age;

        //member property
        public string Jobtitle
        {
            get
            {
                return jobtitle;   
            }

            set
            {
                jobtitle = value;
            }
        }

        //public member method

        public void Introduceyourself(bool isfriend)
        {
            if (isfriend)
            {
                sharingprivateinfo();
            }
            else
            {
                Console.WriteLine("hi my name is {0} and my job title is {1}" , membername , jobtitle);
            }

        }
        private void sharingprivateinfo()
        {
            Console.WriteLine("my salary is {0}" , salary);
        }

        //member constructor

        public members() //the constructor is automatically called when we create a new object , so the code here will be excuted whenever u create an object
        {
            age = 30;
            membername = "lucy";
            salary = 6000000;
            jobtitle = "developer";
            Console.WriteLine("obj created");
        }

        //member-finalizer-destructor , class can have only 1 destructor , can't be inherited or called , whenever our object runs out of scope the finalizer will be called
        ~members()
        {
            //cleaning up statements
            Console.WriteLine("deconstruction of members object");
            Debug.Write("deconstruction of members object");
        }
    }
}

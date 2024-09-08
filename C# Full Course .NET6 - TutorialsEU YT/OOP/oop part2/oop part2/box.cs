using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop_part2
{
    internal class box
    {
        //member variables
        private int length=10;
        private int height;
        private int width;
        private int volume;

        public void displayinfo()
        {
            Console.WriteLine("lentgh is the {0} and height is {1} and width is {2} and vloume is {3}",length , height , width , volume=length*height*width);
        }
        //property
        public void setlength(int length)
        {
            if (length < 0)
            {
                throw new Exception("length should be higher than 0");
            }
            else
            {
                this.length = length;
            }
        
        }
        //property
        public int getlength() //we made it int because we will use return keyword and void returns no value
        {
            return this.length;
            
        }
        
        //a short way to make property instead of making 2 methods set and get u are making just one method 
        public int Height //properties should always start with a capital letter like "H" here
        {
            get
            { 
                return height;
            }

            set 
            {
                if(value < 0)
                { 
                    height = - value; //because minus minus = positive 
                }
                else 
                {
                height=value;
                }
                 /*the "value" keyword here is that its a variable to store the value of height that u will set ,
                                  it will be stored at the "value" keyword and then it will be stored at the height variable*/

                 //we used "value" because here we took no parameter , compare this short way with the methods get,set we made individually
            }


        }

        /*you shouldn't have a member variable for the property ,
          this means that if u need to do a height property , its not a must that u have a member variable called height*/

        //shortcut for property , prob and press tab
        public int Width
        { get;

            set;
        }

        public int Volume
        {
            get
            {
                return volume;
            }

            set            
            {
                this.volume = value;
            }
        }

        public box(int length,int height, int width)
        { 
            this.length=length;
            this.height=height;
            Width=width; //notice what we did here
        }






    }
}

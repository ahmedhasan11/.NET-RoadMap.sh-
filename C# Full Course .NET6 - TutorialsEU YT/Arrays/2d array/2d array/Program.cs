using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D array
            string[,] matrix;



            //3D array 
            int[,,] d3matrix;

            //two-dimensional array

            int[,] array2D = new int[,]
            {
            {1,2,3},//row 0
            {4,5,6},//row 1
            {7,8,9} //row 2 

            };
            Console.WriteLine("central value is {0}", array2D[1, 1]);

            string[,,] array3matrix = new string[,,]
            {
                {
                    {"000","001" },//00 row          third number is the order of the number in columns u want to print or get so 0 is first , 1 second

                    {"010","011" },//01 row             third number is the order of the number in columns u want to print or get so 0 is first , 1 second

                    { "hi there","wassup"} //02 row            third number is the order of the in columns number u want to print or get so 0 is first , 1 second

                },

                {
                    {"100","101"},//10 row            third number is the order of the number in columns u want to print or get so 0 is first , 1 second

                    {"110" , "111" },//11 row          third number is the order of the number in columns u want to print or get so 0 is first , 1 second

                    {"another one","last entry" }//12 row        third number is the order of the numberin columns u want to print or get so 0 is first , 1 second

                }
            };
            string[,] array2dstring = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" } 
            };

            array2dstring[1, 1] = "CHICKEN";

            int dimensions = array2dstring.Rank; //this will gets the rank (num of dimensions of the array (its 2d or 3d))

            int[,] array2d2 = { { 1, 2 }, { 3, 4 } };


            Console.WriteLine("central value is {0}", array2dstring[1, 1]);
        }
    }
}
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged array is multiple arrays within one array , or an array within an array 

            //declararation

            //datatype [][] arrayname = new datatype[number of arrays][];
            int[][] jaggedarray = new int[3][];

            jaggedarray[0] = new int[5]; //5 values          //at pos 0 i have an array with 5 values
            jaggedarray[1]=new int[3]; //3 values           //at pos 1 i have an array with 3 values
            jaggedarray[2]=new int[2]; //2 values           //at pos 2 i have an array with 2 values

            jaggedarray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedarray[1] = new int[] {1,2,3 };
            jaggedarray[2] = new int[] { 13, 21 };

            //alternative way  is to create the jaggedarray and add the values

            int[][] jaggedarray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 }, //this the first position or 1st row , 5 is third pos (the second in order (bcs we start with 0))
                new int[] { 1, 2, 3 },
            };

            Console.WriteLine("the value in thd middle is {0}", jaggedarray2[0][2] );

            //try to get all the values and print them
                
            for( int i = 0; i < jaggedarray2.Length; i++ ) 
            {
                Console.WriteLine("element {0}",i); //element here or (i) is the number of the row you are in it now , or the position of the array you are currently using in your jagged array

                for ( int j = 0; j < jaggedarray2[i].Length; j++) /*jaggedarray2[i].Length , this will return the length of the first array in our jagged array
                 ,that is this : new int[] { 2, 3, 5, 7, 11 } , so you tell him here that he prints the columns so he is checking the condition
                    and if yo see the execution so he is printing the columns of the array u choosed in the outer loop(i)*/
                {
                    Console.WriteLine("the values of the jagged array are {0}" , jaggedarray2[i][j]);

                }
            
            
            }
            








        }
    }
}

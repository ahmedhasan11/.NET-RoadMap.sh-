using System;

namespace HelloWorld
{
    class Program
    {

        static int[,] matrix =      //we made it static because we are using it inside the main method which is static already
            {
                {1, 2, 3, },
                {4, 5, 6, },
                {7, 8, 9}

            };

        static void Main(string[] args)
        {
            //using foreach to pring the 2d array
            foreach (int item in matrix)
            {
                Console.WriteLine(item + "");

            }

            //now we need to go through out 2darray and print it using nested for loop

            for (int i = 0; i < matrix.GetLength(0); i++) //matrix.getlength(0) method will return the rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++)  //matrix.getlength(1)method will return the columns
                {
                    Console.WriteLine(matrix[i,j] + ""); 
                    //the iterations will be the following: [0,0] / [0,1] / [0,2] /[ 1,0] / [1,1] / [1,2] / [2,0] / [2,1] / [2,2]
                }
            }

        }
    }
}

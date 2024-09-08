using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace arrays
{
    internal class _2d_array
    {
        //2D array
        string[,] matrix;

        //3D array 
        int[, ,] d3matrix;

        //two-dimensional array

        int[,] array2D = new int[,]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
            
        };
        Console.WriteLine("central value is {0}",array2D[1,1]);

    }
}

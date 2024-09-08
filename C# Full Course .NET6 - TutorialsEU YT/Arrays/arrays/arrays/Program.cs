using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        //array initialiation
            //datatype [empty] arayname;     //datatype[empty] arrayname = new datatype [amount of entries];            //arrays start with index 0
            //datatype [empty] arrayname={valuee,value,........};            datatype[ empty]grade=new int[ empty] {value,value,value,.................}

            //    int[] grades;                                                               int[]grade=new int[5];

            //     int[] gradeofmath = { 20, 13, 12, 8, 8 };                        int[] gradessss = new int[] {20,13,13 };
                
            ////accessing the data
            //grade[0] = 20;
            //grade[1] = 15;
            //grade[2] = 12;
            //grade[3] = 9;
            //grade[4] = 7;


            //string input = Console.ReadLine();
            //grade[0] = int.Parse(input);

            //int[] gradesofmathstudents = new int[] { 15, 20, 3, 17, 18, 15 };
            //Console.WriteLine("{0}", gradesofmathstudents.Length); //if u want to get the length of an array , use length keyword

            ////////for each loop
            //int[]nums=new int[10];

            //for(int i = 0;i<10;i++)
            //{
            //    nums[i] = i;
            //}

            //for(int j = 0; j < nums.Length ; j++)
            //{
            //    Console.WriteLine("element {0} = {1}",j, nums[j]);

            //}

            //int counter = 0;

            //foreach(int k in nums) //create a var called k and run it in the whole array
            //{
            //    Console.WriteLine("element {0}={1}",counter , k );
            //    counter++;
            //}

            int[] bff = new int[5];
            int counter2 = 0;

            foreach(int k in bff)
            {
                Console.WriteLine("element{0} = {1}",counter2 , k);
                    counter2++;
            }

        }

    }
}

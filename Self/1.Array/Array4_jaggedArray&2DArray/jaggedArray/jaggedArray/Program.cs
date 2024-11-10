using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int [3][]; // 3 rows and no of colum is unspecified
            //j_arr1[0] = new int[2]; // first row has 3 column
            //j_arr1[1] = new int[3]; // this row has 3 column
            //j_arr1[2] = new int[4]; // this row has 2 column

           
            jagged_arr[0] = new int[2] {1,4}; 
            jagged_arr[1] = new int[3] {5,7,9};
            jagged_arr[2] = new int[4] {10, 12, 14, 16};

            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for(int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.Write(jagged_arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Array 2 ");

            //using direct method
            int[][] jagged_arr1 = new int[][]
                               {
                                 new int[] {1, 2, 3, 4},
                                 new int[] {11, 34, 67},
                                 new int[] {89, 23},
                                 new int[] {0, 45, 78, 53, 99}
                    
                               };

            for (int i = 0; i < jagged_arr1.Length; i++)
            {
                for (int j = 0; j < jagged_arr1[i].Length; j++)
                {
                    Console.Write(jagged_arr1[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][,] jagged_arr1 = new int[4][,]
            {
             new int[, ] { {1, 3}, {5, 7} },
             new int[, ] { {0, 2}, {4, 6}, {8, 10} },
             new int[, ] { {7, 8}, {3, 1}, {0, 6} },
             new int[, ] { {11, 22}, {99, 88}, {0, 9} }
                          
            
            };
            //for (int i = 0; i < jagged_arr1.length; i++)
            //{
            //    for (int j = 0; j < jagged_arr1[i].length; j++)
            //    {
            //       for(int k = 0; k < jagged_arr1[i][j].length; k++)
            //        {
            //            ja
            //        }
            //    }
            //    console.writeline();
            //}
            //Can not acess them?


            // Iterate through each 2D array in the jagged array
            for (int i = 0; i < jagged_arr1.Length; i++)
            {
                Console.WriteLine("Array " + (i + 1) + ":");

                // Iterate through the rows of the current 2D array
                for (int j = 0; j < jagged_arr1[i].GetLength(0); j++)
                {
                    // Iterate through the columns of the current 2D array
                    for (int k = 0; k < jagged_arr1[i].GetLength(1); k++)
                    {
                        Console.Write(jagged_arr1[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}

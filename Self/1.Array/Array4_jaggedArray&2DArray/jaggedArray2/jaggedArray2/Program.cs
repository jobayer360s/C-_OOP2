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
            for (int i = 0; i < jagged_arr1.Length; i++)
            {
                for (int j = 0; j < jagged_arr1[i].Length; j++)
                {
                    Console.Write(jagged_arr1[i][j] + " ");
                }
                Console.WriteLine();
            }
            //Can not acess them?

            Console.ReadKey();

        }
    }
}

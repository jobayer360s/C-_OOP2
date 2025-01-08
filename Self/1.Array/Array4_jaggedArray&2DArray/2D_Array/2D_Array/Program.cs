using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr1 = new int[3][];
            int [][] arr2 = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                arr1[i] = new int[3];
                arr2[i] = new int[3];
            }

            Console.WriteLine("Input array 1 ");
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Input A[" + i + "][" + j + "] ");
                    arr1[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Input array 2 ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write("Input A[" + i + "][" + j + "] ");
                    arr2[i][j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine();
            Console.WriteLine("Printing Matrix 1 ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j]+" ");
                }
                Console.WriteLine() ;
            }


            Console.WriteLine("Printing Matrix 2 ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Summation of the matrixes ");
            int[][] sum = new int[arr1.Length][];
            for (int i = 0; i < 3; i++)
            {
                sum[i] = new int[3];
            }

            for (int i = 0; i < 3; i++)
            {
              for(int j = 0;j < arr1[i].Length; j++)
                {
                    sum[i][j] = arr1[i][j] + arr2[i][j];
                }
            }


            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(sum[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

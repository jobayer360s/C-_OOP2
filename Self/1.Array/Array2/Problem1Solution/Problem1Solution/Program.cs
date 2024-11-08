using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array ");
            int size= int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.Write("Enter array elements ");
            for (int i = 0; i < size; i++) { 
                Console.Write("Enter element "+(i+1)+": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < size; i++) { 
            sum += arr[i];
            
            }
            Console.WriteLine("Summation of the array is " + sum);
            Console.ReadKey();
        }
    }
}

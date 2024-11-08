using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length ");
            String x = Console.ReadLine();
            int n = int.Parse(x);

            Console.WriteLine("First pattern");
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                 Console.WriteLine();

               
            }

            Console.WriteLine();    

            Console.WriteLine("Second pattern");
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = i; j<n; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();


            }



            Console.ReadKey();
        }
    }
}


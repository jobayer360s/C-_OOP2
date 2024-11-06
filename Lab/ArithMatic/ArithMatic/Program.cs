using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithMatic
{
    internal class Program
    {
        static int summation(int x, int y) { 
          int result = x+ y;
            return result;
        }
        static void Main(string[] args)
        {
            //For Loop
            for (int i = 0; i <5; i++) { 
                Console.Write(i+" ");
            }

            //while loop
            Console.WriteLine();    
            int j = 0;
            while (j < 5) {
                Console.Write(j + " ");
                j++;
            }

            Console.WriteLine();
            // do while loop
            int k = 0;
            do {
             Console.Write(k + " ");
                k++;
            } while (k < 5);

            Console.WriteLine("\nSummation of 5 amnd 10 is "+summation(5,10));
       
            
                
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfTest
{
    internal class Program
    {

        public static int ADD(params int[] val)
        {
            int sum = 0;

            for (int i = 0; i < val.Length; i++) {
            
            sum += val[i];
            
            }

            return sum;


        }

        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 3 };
            Console.WriteLine("Summation is "+ADD(x));

            Console.ReadKey();
        }
    }
}

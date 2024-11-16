using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Params
{
    internal class Program
    {//when the numbers of parameter unknown then we use params
        public static int add(params int[] val)
        {
            int sum = 0;
            foreach (int i in val)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int a = Program.add(1, 2, 3);
            Console.WriteLine(a);
            Console.WriteLine("array as input");
            int[] arr = new int[5] { 10, 15, 20, 25, 30 };
            int b = Program.add(arr);
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}

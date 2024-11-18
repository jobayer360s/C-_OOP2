using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MethodOverLoading

{
    class Additon
    {
        public int x;
        public int y;
        public int z;

        public int sum(int x, int y)
        {
            int summation;
            return summation = x + y;
        }
        public int sum(int x, int y, int z) {
            int summation;
            return summation = x+y+z;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Additon additon = new Additon();
            Console.WriteLine(additon.sum(1,2));
            Console.WriteLine(additon.sum(1, 2,3));

            Console.ReadKey();
        }
    }
}

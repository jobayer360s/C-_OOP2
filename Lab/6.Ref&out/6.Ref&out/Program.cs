using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ref_out
{
    class Human
    {
        public int valuePass(ref int val)
        {
            val += 10;
            return val;
        }

        public int valuePass2(out int val)
        {
            val = 10; // only initialize 
            return val;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Human h = new Human();
            Console.WriteLine(x);
            Console.WriteLine(h.valuePass(ref x));// after adding ref in method value changed , int val only value pass kore
            Console.WriteLine(x);
          
             
            Human h2 = new Human();
            int y;
            //Console.WriteLine(y);
            Console.WriteLine(h.valuePass2(out y));// assign values

            Console.ReadKey();
        }
    }
}

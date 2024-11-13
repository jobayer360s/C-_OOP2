using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.As_is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 10;
            bool b = a is string; // is operator is used for type cheack
            Console.WriteLine(b);

            object c = "10"; // if object = 10, then output will show null as it is not string according to next line 
            string d = c as string;
            Console.WriteLine(d);
           

            Console.ReadLine();
        }
    }
}

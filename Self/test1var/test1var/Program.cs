using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I hate Sesrami");
            var x = Console.ReadLine();
            Console.WriteLine(x);  
            Console.WriteLine("The type of X is "+x.GetType());//why everthing is showing string?
           // Console.WriteLine(x.System.ValueType());

            Console.ReadKey();
        }
    }
}

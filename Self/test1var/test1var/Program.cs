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
            Console.Write("Enter anything ");
            var x = Console.ReadLine();
            Console.WriteLine(x);  
            Console.WriteLine("The type of X is "+x.GetType());//why everthing is showing string? Becasue readline accepts only string
           // Console.WriteLine(x.System.ValueType());

            var y = 15; 
            Console.WriteLine("The type of y is "+y.GetType());
            Console.WriteLine("Value of y {0}", y);


            var z = 23.456;
            Console.WriteLine("The type of z is " + z.GetType());
            Console.WriteLine("Value of z {0}", z);

            Console.ReadKey();
        }
    }
}

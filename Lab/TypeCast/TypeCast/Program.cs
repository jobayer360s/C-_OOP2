using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypeCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("implicit Type casting example ");
            int num1 = 10;
            double num2 = num1;
            Console.WriteLine(num2); //automatically typecasted

            Console.WriteLine("Explicit Type casting example ");
            double num3 = 10.54;
            //int num4 = num3;// this will give error as it is explicit, explecit typecasting is not possible automatically
            //for explicit type casting we should follow this method
            int num4 = (int)num3;
            Console.WriteLine(num4); // output will be 10, here some data will be losted

            Console.WriteLine("parse Type casting example ");
            string num5 = "20.36";
            double num6 = double.Parse(num5);
            Console.WriteLine(num6);

            Console.WriteLine("Try parse 1");
            int result;
            bool sucess = int.TryParse(num5, out result);
            Console.WriteLine(sucess);
           // for succesful type cast it will return True otherwise false, used for exception handle
            Console.WriteLine(result);

            Console.WriteLine("Try parse 2");
            double result2;
            bool sucess2 = double.TryParse(num5, out result2);
            Console.WriteLine(sucess2);
            Console.WriteLine(result2);


            Console.ReadKey(); 
        }
    }
}

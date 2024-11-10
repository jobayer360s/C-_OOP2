using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TypecastPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit typecast 
            int number = 15;
            double number1 = number;
            Console.WriteLine(number1);

            Console.WriteLine("Explicit typecasting ");
            double number2 = 21.456;
            int number3 = (int)number2;
            Console.WriteLine(number3);

            Console.WriteLine("Parse typecasting ");
            string number4 = "456.1456";
            double number5 = double.Parse(number4);
            Console.WriteLine(number5);

            Console.WriteLine("Try Parse 1");
            double result;
            bool sucess = double.TryParse(number4, out result);
            Console.WriteLine("Succsess? : "+sucess);
            Console.WriteLine(result);

            Console.WriteLine("Try Parse 2");
            int result2;
            bool sucess2 = int.TryParse(number4, out result2);
            Console.WriteLine("Succsess? : " + sucess2);
            Console.WriteLine(result2);

            //int result3 = int.Parse(number4);
            //Console.WriteLine(result3);
            //Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = a;
            Console.WriteLine(b);

            //explicit Type Cast
            double c = 10.256;
            int d =(int)c;  
            Console.WriteLine(d);

            String s = "125.66";
            double e = double.Parse(s);
            Console.WriteLine(e);

            Console.WriteLine("Try Parse 1 ");
            double result;
            bool success = double.TryParse(s, out result);
            Console.WriteLine("Success "+success);
            Console.WriteLine(result);


            string s2 = "Hello ";
            double result2;
            bool success2 = double.TryParse(s2, out result2);
            Console.WriteLine(success2+"  "+result2);

            Object o1 = "hellooo Baba hello ";
            string x = o1 as string;
            Console.WriteLine(x);

            const int con1 = 100;
            


            Console.ReadKey();

        }
    }
}

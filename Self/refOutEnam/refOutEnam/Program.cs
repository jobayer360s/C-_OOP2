using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refOutEnam
{
    class Program
    {
        //ref , ref can modify values
        public static void ModifyValue(ref int x) {

            x *= 5;
        
        }

        public static void initialization(out int x)
        {
            x = 10;
        }

        // enum

        enum Level
        {
            Low, Medium, High
        }

        enum Months
        {
            January, 
            February , 
            March ,
            April ,
            May ,
            June, 
            July,
            Augast ,
            September , 
            October ,
            November , 
            December
        }

        static void Main(string[] args)
        {
            //ref ,and out are used for pass value by aurguments
            //ref can modify values
            int a = 20;
            Console.WriteLine("The value of 'a' before modify {0}",a);
            ModifyValue(ref a);
            Console.WriteLine("The value of 'a' after modify {0}", a);

            int b;
            //Console.WriteLine("The value of 'b' before initalization {0}", b); // its not possible as it is not initialized
            initialization(out b);
            Console.WriteLine("The value of 'b' after initalization {0}", b);

            // what happened after passing initalized value, Lets check it.

            int c = 20;
            initialization(out c);
            Console.WriteLine(c);

            Console.WriteLine();
            Console.WriteLine("Enum out puts");
           Level l1 = Level.Medium;
            Console.WriteLine(l1);

            Console.WriteLine("Enum 2");
            int months = (int)Months.June;
            Console.WriteLine(months);

            Console.ReadKey();
        }
    }
}

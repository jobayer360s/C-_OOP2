using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsParams
{
    public class p { }
    public class p1 : p { }

    public class p2 { }



    internal class Program
    {

        // Use of Params 

        public static int Add(params int[] numbers)
        {
            int total = 0;

            //foreach (int value in numbers)
            //{
            //    total += value; // Add each number to the total
            //}

            for (int i = 0; i < numbers.Length; i++) 
            {
             total = total + numbers[i];
            
            }

            return total; // Return the total sum
        }

        static void Main(string[] args)
        {
            int a = 100;
            bool b = a is int;
            Console.WriteLine(b);
            Console.WriteLine(a is string);

           p o1 = new p();
            p1 o2 = new p1();

            Console.WriteLine(o1 is p);
            Console.WriteLine(o1 is Object);
            Console.WriteLine(o2 is p);
            Console.WriteLine(o2 is p1);


            Console.WriteLine("As Operator ");
            Object c = "Hello ";
            string d = c as String;
            Console.WriteLine(d);

            Object[] o = new Object[5];
            o[0] = new p();
            o[1] = new p();
            o[2] = new p();
            o[3] = "I love you too ";
            o[4] = "I love crow ";

            Console.WriteLine();
            Console.WriteLine();
           
            for (int i = 0; i < o.Length; i++)
            {
                string x = o[i] as string;
                if (x == null) {
                    Console.WriteLine("No string , Null ");
                }
                else
                {
                    Console.WriteLine(x);
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Params ");

            int[] numbers = new int[5] { 10, 20 , 30 ,40 ,  50};
            int summation = Add(numbers);
            Console.WriteLine("The summation is {0}",summation);

            Console.ReadKey();

        }
    }
}

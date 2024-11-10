using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_ReadOnly
{
    public class square
    {
        public readonly double length;
        public square(double length) { this.length = length; }

       public double squareArea(double l)
        {
            double area = l * l;
            return area;
        }
        public void display()
        {
            Console.WriteLine("Length is "+length);
            Console.WriteLine("Area is "+squareArea(length));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            Console.Write("Enter a radius of circle : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area is : "+pi*radius);

            square s1 = new square(4);
           
            Console.WriteLine(s1.length);
            // s1.length = 10; not possible as it is readonly
            s1.display();
            Console.ReadKey();
        }
    }
}

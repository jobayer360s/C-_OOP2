using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
  
    class Program
    {
        public static double circleArea(double x)
        {
            double y = 3.1416 * x;
            return y;
        }

        public static double rectangularArea(double x, double y) {

            double area = x*y;
            return area;
        }

        public static double triangleArea(double x , double y) {
            double area = 0.5*x*y;

            return area;
        }
        static void Main(string[] args)
        {  
            Console.Write("Enter radius of circle ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle Area " +circleArea(radius));

            Console.WriteLine("Enter the lengths of rectangles ");
            double s1 = double.Parse(Console.ReadLine());
            double s2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is "+rectangularArea(s1,s2));

            Console.WriteLine("Enter  land and height of a Triangle ");
            double triangleLand = double.Parse(Console.ReadLine());
            double triAngleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is " +triangleArea(triAngleHeight,triAngleHeight));

            Console.ReadKey();
        }
    }
}

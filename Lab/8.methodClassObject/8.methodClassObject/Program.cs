using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.methodClassObject
{
    class Human

    {
        private int id;
        public int sabbirHossin(int val) {
            val+= 10 ;
            Console.WriteLine("Sabbir Hossain Called {0}", val);
             return val;
        
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Console.WriteLine(h1.sabbirHossin(10));
            
          // to access static method we don't need any Object, just use classname.MethodName()
            Console.ReadKey();
        }
    }
}

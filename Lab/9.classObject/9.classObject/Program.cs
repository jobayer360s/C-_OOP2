using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.classObject
{
    class Bus
    {
        private string name;
        private int wheel;
        private static int driver;
        private int seat;
        private static int healper;

        //constructor , no returnt type , same as class name
        public Bus()
        {
            // default constructor
            Console.WriteLine("Default Constuructor called");
        }

        //parameter constructor
        public Bus(string name, int wheel, int seat)
        {
            this.name = name; // this.name -> class er name, only "name" = Local variable
            this.wheel = wheel;
            this.seat = seat;
            Console.WriteLine("Parameter Constuructor called");
        }

        //copy constructor
        public Bus(Bus bus) { 
           name = bus.name;
           wheel = bus.wheel;
           seat = bus.seat;
            Console.WriteLine("Copy Constuructor called");
        }
        // static constructor , for assigning static values
        // static will called at first. static called before the object creation
        // static is the value which are same for everyone
        static Bus()
        {
            Console.WriteLine("Static Constuructor called");
            driver = 1;
            healper = 2;
        }
        //Destructor
        ~ Bus(){
            Console.WriteLine("Destructor called");
            //press FN+ F5 to see destructor
        }
        public void display()
        {
            Console.WriteLine(name+" "+wheel+" "+seat);
            Console.WriteLine(driver);
            Console.WriteLine(healper);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Bus bus = new Bus();
                Bus bus1 = new Bus("Shohagh",4,36);
                Console.WriteLine(bus1.name);
                bus1.display();

                Bus bus2 = new Bus(bus1);
                Console.WriteLine("Bus 2 information ");
                bus2.display();


                Console.ReadKey();
            }
        }
    }
}

using System;

namespace _10.ClassAndObjectUsing_SetGet
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
        public Bus(Bus bus)
        {
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


        //set get
        public void setName(string name)
        {
            this.name = name;
        }

        public void setWheel(int wheel)
        {
           this.wheel = wheel;
        }

        public void setSeat(int seat)
        {

            this.seat = seat;
        }

        public string getName()
        {
            if(name == null)
            {
                Console.WriteLine("Enter Name Correctly ");
                return null;

            }
            else {  return name;
            }
          //  return name;
        }

        public int getWheel()
        {
            return wheel;
        }

        public int getSeat() { return seat; }

        //Destructor
        ~Bus()
        {
            Console.WriteLine("Destructor called");
            //to see destructor press Fn+ f5
        }
        public void display()
        {
            //Console.WriteLine(name + " " + wheel + " " + seat);
            Console.WriteLine("Name "+getName());
            Console.WriteLine("Wheel " + getWheel());
            Console.WriteLine("Seat "+getSeat());
            Console.WriteLine(driver);
            Console.WriteLine(healper);
        }
        internal class Program
        {
          
            static void Main(string[] args)
            {
             

                Bus bus = new Bus();
                bus.setName("Hanif");
                bus.setWheel(4);
                bus.setSeat(36);
                Console.WriteLine(bus.getName() + " " +bus.getWheel()+" "+bus.getSeat());


               Console.ReadKey();
            }
        }
    }
}

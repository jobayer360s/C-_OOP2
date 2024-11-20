using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Polymorphism
{
    class Player
    {
        private string name;
        private int age;

        public Player()
        {

            Console.WriteLine("Default Constructor called , (Player) ");

        }
        public Player(string name, int age)
        {
            Console.WriteLine("Parameter Constructor called (Player )");
            this.name = name;
            this.age = age;

        }

        public virtual void Display() // virtual keyword is used for method over riding
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }


        class Footballer : Player
        {
            public string gameType;



            public Footballer()
            {

                Console.WriteLine("Default Constructor called , (Footballr) ");

            }

            public Footballer(string name, int age, string gameType) : base(name, age)
            {

                Console.WriteLine("Parameter Constructor called , (Footballr) ");
                this.gameType = gameType;


            }

            public override void Display() // for using  override keyword , we must use virtual keyword at parent class's Display
            { 
            base.Display();
                Console.WriteLine("Game type : "+gameType);
            
            }



        }


            internal class Program
        {
            static void Main(string[] args)
            {
                Player player = new Player("Nipun ", 40);
                player.Display();

                Footballer f = new Footballer("Leo messi ", 35 ,"Football ");
                f.Display();

                Console.WriteLine();
                Console.WriteLine("Array of objects here");

                Footballer [] fs = new Footballer [2];
                fs[0] = new Footballer("Ronaldo ", 45, "FootballP ");
                fs[1] = new Footballer("Tariq Monwar ", 68, "English League ");

                foreach (Footballer i in fs)
                {
                 i.Display();   
                }

                Console.ReadKey();
            }
        }
    }
}

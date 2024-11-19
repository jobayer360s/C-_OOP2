using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Inheritance
{
    class Person
    {
        private string name;
        private int age;

        public Person() { }

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameter Constructor person (Parent) ");
        }

        //set get different rule
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Display()
        {
            Console.WriteLine(name + " " + age);
        }
    }
    class Employee : Person
    {

        private int salary;
        public Employee() { }
        public Employee(string name, int age, int salary) : base(name , age) 
        {
            this.salary = salary;
            this.Name = name;
            Console.WriteLine("Parameter Constructor Child (Employee) ");

        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }


        }

        public void Display1() {
            base.Display();
            Console.Write(Name+"'s Salary  "+Salary+" Taka ");
        }

    }

    //Its a multiLevel inheritance now ,
    class Student : Employee
    {
        private int credit;
        public Student() { }
        public Student(string name, int age, int salary, int credit) : base(name, age, salary) {
            this.credit = credit;
            Console.WriteLine("Parameter Constructor child2(Student)");
        }
        public int Credit{
            get { return credit; }
            set{ credit = value;  }

          }
        public void Display2()
        {
            base.Display1();
            Console.WriteLine(Name+" has completed "+credit+"Credits. ");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Dr younus" , 81);
            p1.Display();
            Employee p2 = new Employee("Hasina",65 ,100);
            p2.Display1();
            Student s1 = new Student("Mir Mugdho",25,999990,100);
            s1.Display2();
            

            Console.ReadKey();
        }
    }
}
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
            Console.WriteLine(Name + " " + age);
        }
    }
    class Employee : Person
    {

        private int salary;
        public Employee() { }
        public Employee(string name, int salary)
        {
            this.salary = salary;
            this.Name = name;

        }

        public int Salary
        {
            get { return salary; }


        }

        public void Display1() {
            base.Display();
            Console.Write("Salary  "+Salary);
        }

    }

    class Student
    {


    }
    //Its a hierarcycal inheritance,
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Dr younus" , 81);
            p1.Display();
            Employee p2 = new Employee("Hasina ", 100);
            p2.Display1();
            Console.ReadKey();
        }
    }
}
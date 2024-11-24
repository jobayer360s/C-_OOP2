using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AIUB
    {
        private String Name;
        private String ID;
        private String Phone_Number;
        static int studentAdmission;

        public AIUB() { }

        public AIUB(String Name, String ID, String Phone_Number)
        {
            this.Name = Name;
            this.ID = ID;
            this.Phone_Number = Phone_Number;
        }

        public AIUB(AIUB aiub)
        {
            Name = aiub.Name;
            ID = aiub.ID;
            Phone_Number = aiub.Phone_Number;
        }

        static AIUB()
        {
            studentAdmission = 1000;
        }

        public virtual void Showinfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + ID);
            Console.WriteLine("Phone Number: " + Phone_Number);
        }
    }

    class Students : AIUB
    {
        private String Courses;
        private int Credit_Load;
        private double Cgpa;

        public Students() { }

        public Students(String Name, String ID, String Phone_Number, String Courses, int Credit_load, double Cgpa)
            : base(Name, ID, Phone_Number)
        {
            this.Courses = Courses;
            this.Credit_Load = Credit_load;
            this.Cgpa = Cgpa;
        }

        public Students(Students students)
        {
            this.Courses = students.Courses;
            this.Cgpa = students.Cgpa;
            this.Credit_Load = students.Credit_Load;
        }

        public String courses
        {
            get { return Courses; }
            set { Courses = value; }
        }

        public double cgpa
        {
            get { return Cgpa; }
            set { Cgpa = value; }
        }

        public int creditLoad
        {
            get { return Credit_Load; }
            set { Credit_Load = value; }
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Courses: " + courses);
            Console.WriteLine("Credit Load: " + creditLoad);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }

    class Faculties : AIUB
    {
        private int Hours;
        private int Total_credits;
        private double Salary;

        public Faculties() { }

        public Faculties(String Name, String ID, String Phone_Number, int Hours, int Total_credits, double Salary)
           : base(Name, ID, Phone_Number)
        {
            this.Hours = Hours;
            this.Total_credits = Total_credits;
            this.Salary = Salary;
        }
        public Faculties(Faculties f1)
        {
            this.Hours = f1.Hours;
            this.Total_credits = f1.Total_credits;
            this.Salary = f1.Salary;
        }

        public int hours
        {
            set { Hours = value; }
            get { return Hours; }
        }

        public int TotalC
        {
            set { Total_credits = value; }
            get { return Total_credits; }
        }

        public double salary
        {
            set { Salary = value; }
            get { return Salary; }
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Total Credits: " + TotalC);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Employee : AIUB
    {
        private String Courses;
        private double Salary;

        public Employee() { }

        public Employee(String Name, String ID, String Phone_Number, string Courses, double Salary)
           : base(Name, ID, Phone_Number)
        {
            this.Courses = Courses;
            this.Salary = Salary;
        }

        public Employee(Employee e1)
        {
            this.Courses = e1.Courses;
            this.Salary = e1.Salary;
        }

        public string courses
        {
            get { return Courses; }
            set { Courses = value; }
        }

        public double salary
        {
            set { Salary = value; }
            get { return Salary; }
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Courses: " + courses);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AIUB aIUB = new AIUB("Tonny","1246","0123654987");
            aIUB.Showinfo();
            
            Students students = new Students("Jobayer", "23-50647-1", "01756111111", "C sharp, MicroProcessor", 15, 3.9);
            students.Showinfo();

            Faculties f = new Faculties("Saikut Baul", "10-10547-1", "1455224444", 10, 12, 100);
            f.Showinfo();

            Employee e1 = new Employee("Sakib Rahman", "19-10001", "+8801647856555", "Computer Vision", 1000);
            e1.Showinfo();

            Console.ReadKey();
        }
    }
}

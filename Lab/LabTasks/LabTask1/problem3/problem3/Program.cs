using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{  
    struct Student
    {
        public string FirsrName;
        public String LastName;
        public String BirthDate;
        public String AddressLine1;
        public String AddressLine2;
        public String city;
        public String state;
        public int Zip;
        public String country;
    }

     class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            Console.WriteLine("Enter information ");

            Console.Write("Enter First name ");
             s1.FirsrName = Console.ReadLine();

            Console.Write("Enter Last name ");
            s1.LastName = Console.ReadLine();

            Console.Write("Enter BirthDay ");
            s1.BirthDate = Console.ReadLine();

            Console.Write("Enter Address Line 1 ");
            s1.AddressLine1 = Console.ReadLine();

            Console.Write("Enter Address Line 2 ");
            s1.AddressLine2 = Console.ReadLine();

            Console.Write("Enter City ");
            s1.city = Console.ReadLine();

            Console.Write("Enter state ");
            s1.state = Console.ReadLine();

            Console.Write("Enter Zip ");
            s1.Zip= int.Parse(Console.ReadLine());  

            Console.Write("Enter country ");
            s1.country= Console.ReadLine();

            Console.WriteLine("Student Information ");
            Console.WriteLine("Name " + s1.FirsrName + " " + s1.LastName);
            Console.WriteLine("Birth date is " + s1.BirthDate);
            Console.WriteLine(s1.AddressLine1 + " " + s1.AddressLine2);
            Console.WriteLine("City is " + s1.city + " State " + s1.state);
            Console.WriteLine("zip " + s1.Zip);
            Console.WriteLine("Country " + s1.country);

            Console.ReadKey();
        }
    }
}

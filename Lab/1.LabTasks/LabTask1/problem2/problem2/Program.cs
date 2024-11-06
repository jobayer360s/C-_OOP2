using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information ");

            Console.Write("Enter First name ");
            String FrirstName = Console.ReadLine();

            Console.Write("Enter Last name ");
            String LastName = Console.ReadLine();

            Console.Write("Enter BirthDay ");
            String BirthDate = Console.ReadLine();

            Console.Write("Enter Address Line 1 ");
            String AddressLine1 = Console.ReadLine();

            Console.Write("Enter Address Line 2 ");
            String AddressLine2 = Console.ReadLine();

            Console.Write("Enter City ");
            String city = Console.ReadLine();

            Console.Write("Enter state ");
            String state = Console.ReadLine();

            Console.Write("Enter Zip ");
            int Zip = int.Parse(Console.ReadLine());

            Console.Write("Enter country ");
            String country = Console.ReadLine();

            Console.WriteLine("Student Information ");
            Console.WriteLine("Name " + FrirstName + " " + LastName);
            Console.WriteLine("Birth date is " + BirthDate);
            Console.WriteLine(AddressLine1 + " " + AddressLine2);
            Console.WriteLine("City is " + city + " State " + state);
            Console.WriteLine("zip " + Zip);
            Console.WriteLine("Country " + country);

            Console.ReadKey();
        }
    }
}

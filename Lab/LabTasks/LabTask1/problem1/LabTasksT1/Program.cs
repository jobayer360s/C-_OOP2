using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information ");
            String FrirstName = "Jobayer ";
            String LastName = "Shaikh";
            String BirthDate = " 15-Jun-2000";
            String AddressLine1 = "48/1 Rupsha Strand Rd  ";
            String AddressLine2 = "Ispahani Lane , Khulna  ";
            String city = "Khulna ";
            String state = "Khulna ";
            int Zip = 100;
            String country = "Bangladesh ";

            Console.WriteLine("Name "+FrirstName + " " + LastName);
            Console.WriteLine("Birth date is " + BirthDate);
            Console.WriteLine(AddressLine1+" "+AddressLine2);
            Console.WriteLine("City is " + city + " State " + state);
            Console.WriteLine("zip " + Zip);
            Console.WriteLine("Country " + country);

            Console.ReadKey();
        }
    }
}

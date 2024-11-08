using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I love Allah! ");

            int[] arr = new int[5] { 10, 20, 30 ,40, 50 };
           
            
            //Accressing through for each loop
            foreach (int values in arr) //int values , here values can be any thing and the keyword in is used to identify as input of arrays
            { 
            Console.Write(values+" "); 
            }

            // array without assignig values

            int[] arr2 = new int[5];
            // arr2 = {100, 110 , 120, 140, 150 }; // this is not possible
            arr2[0] = 110;
            arr2[1] = 115;
            arr2[2] = 120;
            arr2[3] = 125;
            arr2[4] = 125;
            Console.WriteLine();
            Console.WriteLine("Arr2 outputs ");
            for(int i = 0; i< arr2.Length; i++) 
                Console.Write(arr2[i]+" ");



            //another way
            int[] arr3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            Console.WriteLine("Length od arr3 is "+arr3.Length);
            Console.WriteLine(arr3[0] + " " + arr3[1]);

            //Array as taking user input and print them
            
            Console.WriteLine("Input size ");
            int size = int.Parse(Console.ReadLine()); 
            int[] arr4 = new int[size];
            for(int i = 0;i<size;i++)
            {
                Console.Write("Enter element/value "+(i+1)+" ");
                arr4[i]= int.Parse(Console.ReadLine()) ;  
            }

            Console.WriteLine("You entered ");
            for (int i = 0; i<size; i++)
            {
                Console.Write(arr4[i]+" ");
            }    


            Console.ReadKey();
        }
    }
}

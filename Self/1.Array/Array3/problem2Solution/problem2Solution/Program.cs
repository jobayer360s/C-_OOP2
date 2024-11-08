using System;

namespace Problem2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (size < 2)
            {
                Console.WriteLine("Array should have at least two elements to find the second largest element.");
                return;
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            if (secondLargest == int.MinValue)
            {
                Console.WriteLine("There is no second largest element.");
            }
            else
            {
                Console.WriteLine("Second largest element is " + secondLargest);
            }

            Console.ReadKey();
        }
    }
}

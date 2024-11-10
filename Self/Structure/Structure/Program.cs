using System;

namespace Structure
{
    

    struct Book
    {
        public string Tittle;
        public string Author;
        public int price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Tittle = "Introduction to c#";
            b1.Author = "ChatGPT and Jobayer";
            b1.price = 100;

            Console.WriteLine("Showing info");
            Console.WriteLine("Book Tittle "+b1.Tittle);
            Console.WriteLine("Author " + b1.Author);
            Console.WriteLine("Price " + b1.price);

            Console.ReadKey();

        }
    }
}

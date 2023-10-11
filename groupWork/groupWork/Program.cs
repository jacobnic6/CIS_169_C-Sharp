using System;

namespace groupWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your full name?");
            string personName = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0}! Your favorite number is {1} and double that is {2}", personName, favoriteNumber,(2*favoriteNumber));


        }
    }
}

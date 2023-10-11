using System;

namespace ConsoleApp2
{
    class Program
    {
        private static void UpdateAge(ref int age)
        {
            age++;
        }
        static void Main(string[] args)
        {
            int age = 14;
            UpdateAge(ref age);
            Console.WriteLine(age);
        }
    }
}

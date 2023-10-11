using System;

namespace unit3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal result = Add(5.5M, 2.1M);
            Console.WriteLine(result);
        }

        //Method, must declare static. The method is "Add" and is called above
        //Must declare variable outside of method if what to call it outside of that method
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}

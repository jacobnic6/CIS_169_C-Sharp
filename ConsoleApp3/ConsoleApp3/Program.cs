using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "MANUEL";
            string str2 = "MANUEL";
            if (String.Compare(str1, str2, true) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are NOT equal.");
            }

        }
    }
}

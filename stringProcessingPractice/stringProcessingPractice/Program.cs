using System;

namespace stringProcessingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your Preferred salutation (Ms, Mr, Mx):");
            string personSalutation = Console.ReadLine();
            Console.WriteLine("Please enter your seat preference:");
            string seatPreference = Console.ReadLine();
            Console.WriteLine($"{char.ToUpper(personSalutation[0]) + personSalutation.Substring(1)}. " +
                $"{char.ToUpper(firstName[0]) + firstName.Substring(1)} {char.ToUpper(lastName[0]) + lastName.Substring(1)}\nSeating Preference: {seatPreference.ToUpper()}");
        }
    }
}

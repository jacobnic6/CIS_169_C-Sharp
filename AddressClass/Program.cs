using System;

namespace AddressClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Address personOneAddress = new Address(123, "Main Street", " Apt J2", "Small Town", "Iowa", 55555);
            Console.WriteLine(personOneAddress.ToString());

            House personOneHouse = new House(222, "Main Street", " Apt J2", "Small Town", "Iowa", 22222, "white");
            Console.WriteLine(personOneHouse.ToString());
        }
    }
}

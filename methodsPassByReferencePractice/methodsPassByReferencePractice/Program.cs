using System;

namespace methodsPassByReferencePractice
{
    class Program
    {
        private static void PrintFourPeoplesAge(int age1, int age2, int age3,int age4)
        {
            Console.WriteLine("Person 1's age is: {0:G} Person 2's age is: {1:G} Person 3's age is: {2:G} Person 4's age is: {3:G}", age1, age2, age3, age4);
            //pass by value because it is just printing their age and not updating
            //return type void because the method isnt going to actually return anything
        }

        private static void UpdateFourPeoplesAges(ref int age1, ref int age2, ref int age3, ref int age4)
        {
            age1++;
            age2++;
            age3++;
            age4++;
            Console.WriteLine("Person 1's age is now: {0:G} Person 2's age is now: {1:G} Person 3's age is now: {2:G} Person 4's age is now: {3:G}", age1, age2, age3, age4);
            //rerference because it is being updated and void because it's not going to return anything till called
        }
        static void Main(string[] args)
        {
            int personOneAge = 88;
            int personTwoAge = 33;
            int personThreeAge = 25;
            int personFourAge = 45;

            PrintFourPeoplesAge(personOneAge, personTwoAge, personThreeAge, personFourAge);

            UpdateFourPeoplesAges(ref personOneAge, ref personTwoAge, ref personThreeAge, ref personFourAge);




        }
    }
}

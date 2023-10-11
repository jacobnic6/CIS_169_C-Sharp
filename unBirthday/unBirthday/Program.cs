/***************************************************************
* Name        : Debugger
* Author      : Nicholas Jacobs
* Created     : 01/23/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program is going to determine how many cupcakes
* each person at the un-birthday party will get.
*               Input:  None
*               Output: Happy (UN)Birthday to me! 
*                       You may have up to () cupcakes!
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace unBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables for people, cupcakes and cupcakes per person
            int numOfPeople = 1;
            int numOfCupcakes = 1;
            int cupcakesPerPerson = 1;

            //gather input of how many people invited and how many cupcakes ordered

            Console.WriteLine("How many people are you inviting to your unbirthday party?");
            //format exceptions
            try
            {
                numOfPeople = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid amount of people");
            }
           
            Console.WriteLine("How many cupcakes did you order?");
            try 
            {
                numOfCupcakes = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid amount of cupcakes.");
            }
            //calculate number of cupcakes per guest, catch divide by 0
            try
            {
                cupcakesPerPerson = numOfCupcakes / numOfPeople;
            } 
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Can't divide by zero");
            }
            //display output
            Console.WriteLine("Happy un-birthday to me! You may have up to {0:G} cupcakes :)", cupcakesPerPerson);

            //calculate remainder
            int cupcakesForMe = numOfCupcakes % numOfPeople;
            Console.WriteLine("There will be {0:G} extra for me!", cupcakesForMe);
        }
    }
}

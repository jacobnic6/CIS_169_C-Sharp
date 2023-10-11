/***************************************************************
* Name        : DaysOfTheWeek
* Author      : Nicholas Jacobs
* Created     : 02/04/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  1
*               Output: Monday is the 1 day of the week.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            string dayOfWeek = "Monday";
            int dayInt;
            Console.WriteLine("Please enter what day of the week it is (1-7)");
            //try catch for when the user enters a values in incorrect format
            try
            { 
                
                dayInt = Convert.ToInt32(Console.ReadLine());
                // use dayInt in the switch because it is the value the user entered
                switch (dayInt)
                {
                    case 1:
                        dayOfWeek = "Monday"; // assign the day with the corresponding value
                        break;

                    case 2:
                        dayOfWeek = "Tuesday";
                        break;

                    case 3:
                        dayOfWeek = "Wednesday";
                        break;

                    case 4:
                        dayOfWeek = "Thursday";
                        break;

                    case 5:
                        dayOfWeek = "Friday";
                        break;

                    case 6:
                        dayOfWeek = "Saturday";
                        break;

                    case 7:
                        dayOfWeek = "Sunday";
                        break;
                        
                    default:
                        dayInt = -1;
                        break; // default in case user enters a number out of the range

                }



                if (dayInt < 0 || dayInt > 7)
                {
                    Console.WriteLine("Invalid format. Must be a number between 1 and 7.");
                }
                else
                {
                    Console.WriteLine(dayOfWeek + " is the " + dayInt + " day of the week."); // output message to the user
                }

            }
             catch (FormatException e)
            {
                Console.WriteLine("Invalid format. Please enter a number between 1 and 7 to find what day of the week it is.");

            }

            
                


            
        }
    }
}

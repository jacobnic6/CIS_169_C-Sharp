/***************************************************************
* Name        : validateInputDoWhileLoop
* Author      : Nicholas Jacobs
* Created     : 02/10/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program takes a user's input and makes sure
*               that it is between 7 and 32
*               Input:  10
*               Output: 10 is an excellent choice of number
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace validateInputDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = 0;
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter a number between 7 and 32");
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum < 7 || userNum > 32) 
                {
                    Console.WriteLine("Invalid input format.");
                }
                else
                {
                    break;
                }
                // Prompt the user for a number between 7 and 32
                // Get the input
                // Test if input is invalid and (update loop condition variable or prompt user that input is incorrect)

            } 
            while (userNum < 7 || userNum > 32);
            {
                Console.WriteLine("{0:0} is an excellent choice of number", userNum);
            }
                // Output message with valid input
        }
    }
}

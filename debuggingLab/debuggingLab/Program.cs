/***************************************************************
* Name        : Debugging Lab
* Author      : Nicholas Jacobs
* Created     : 01/23/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program will be a walkthrough of how to use the debugger
*               Input:  None
*               Output: String Happy Coding!
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace debuggingLab
{
    class Program
    {
        private static string MedalWinner(string fName, string lName, string rank)
        {
            string result;
            fName = fName.Substring(0,1).ToUpper() + fName.Substring(1).ToLower();
            result = fName + " " + lName.ToUpper() + " Rank: ";
            
            try
            {
                result = result + Convert.ToInt32(rank).ToString();
            }
            catch (FormatException e1)
            {
                try
                {
                    result = result + Convert.ToDecimal(rank).ToString();
                }
                catch (FormatException e2)
                {
                    result = result + "undetermined";
                }
                
            }
            return result;
            
        }
        static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank. Nicholas Jacobs
            string winner1 = MedalWinner("MEGAN", "rapinoE", "1");
            string winner2 = MedalWinner("USA", "Women's Soccer", "1");
            string winner3 = MedalWinner("USA", "Women's Soccer", "1.5");
            string winner4 = MedalWinner("USA", "Men's Soccer", "GOLD");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Megan RAPINOE 1");
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER 1");
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1.5 ");
            Console.WriteLine("And the winner is ... {0:G}", winner4);
            Console.WriteLine("Expected: Usa MEN'S SOCCER Rank: undetermined");
        }
    }
}

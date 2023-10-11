/***************************************************************
* Name        : Loops w/Unit Test
* Author      : Nicholas Jacobs
* Created     : 02/12/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program records the users scores and returns the total and avg of the scores.
*               Input:  yes
*                       11
*                Output: Number of Scores: 1
*                      Total Score: 11
*                        Average of Scores: 11
*                        Would you like to enter more scores? (yes or no)
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace Methods
{
   public class Program
    {
        public static string GetUserInput()
        {
            Console.WriteLine("Please enter your score");

            return Console.ReadLine();
        }

        public static int ConvertToInt(string inputString)
        {
            int scoreValue;
            bool convertPassOrFail = false; 
            convertPassOrFail = Int32.TryParse(inputString, out scoreValue);
           if (convertPassOrFail == true)
            {
                if (scoreValue > 0)
                {
                    return scoreValue;
                }
                else
                {
                    
                    return -1;
                }

            }
           else
            {
                
                return -1;
            }
    
        
        }
        public static bool ValidateInput(int inputInt)
        {
            if (inputInt <= 0)
            {
                Console.WriteLine("Incorrect format. Please enter a whole number greater than 0");
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            string userInputBeforeConvert = "";
            int userInputAfterConvert = -1;
            double totalScore = 0;
            double avgScore = 0;
            int numberOfScores = 0;
            


            bool userInputValid = true;
            string userPrompt;
            string initialUserPrompt = "no";
            Console.WriteLine("Would you like to enter your score?");
            initialUserPrompt = Console.ReadLine();

            while (initialUserPrompt.ToLower() == "yes")
            {

              
                ConvertToInt(userInputBeforeConvert);
                userInputBeforeConvert = GetUserInput();
                userInputAfterConvert = ConvertToInt(userInputBeforeConvert);
                


                
                userInputValid = ValidateInput(userInputAfterConvert);
                
                if (userInputValid == false)
                {
                    continue;
                }
                else
                {
                    numberOfScores++;
                    Console.WriteLine("Number of Scores: {0:0}", numberOfScores);
                     totalScore += userInputAfterConvert;
                    Console.WriteLine("Total Score: {0:00}", totalScore);
                    avgScore = totalScore / numberOfScores;
                    Console.WriteLine("Average of Scores: {0:00}", avgScore);
                    Console.WriteLine("Would you like to enter more scores? (yes or no)");
                    userPrompt = (Console.ReadLine());
                    if (userPrompt.ToLower() !="yes")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }

            }
            



        }
    }
}

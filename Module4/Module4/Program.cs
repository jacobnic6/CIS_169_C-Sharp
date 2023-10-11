/***************************************************************
* Name        : Decision w/Unit Test
* Author      : Nicholas Jacobs
* Created     : 02/4/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program is used to tell the user what they will be
*               having for a given meal on a given day of the week
*               Input:  Monday, Lunch
*               Output: VeggieBurger and Fries
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace Module4
{
    public class Program
    {
        public static string DecideMeal(string day, string mealTime)
        {
           
            string meal = "";
            



            if (day == "Monday")

            {
                
                if (mealTime == "lunch")
                {
                    meal = "VeggieBurger and Fries";
                    
                }
                else if (mealTime == "dinner")
                {
                    meal = "Lasagna";
                    
                }
                else
                {
                    meal = "Ice Cream!";
                    
                }
            }
            else if (day == "Tuesday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Chili and cornbread";
                    
                }
                else if (mealTime == "dinner")
                {
                    meal = "Pizza";
                    
                }
                else
                {
                    meal = "Ice Cream!";
                    
                }
            }
            else if (day == "Wednesday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Pad Thai";
                    
                }
                else if (mealTime == "dinner")
                {
                    meal = "Soup and Salad";
                    
                }
                else
                {
                    meal = "Ice Cream!";
                    
                }
            }
            else if (day == "Thursday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Baked Potato";
                    
                }
                else if (mealTime == "dinner")
                {
                    meal = "Spaghetti";
                    
                }
                else
                {
                    meal = "Ice Cream!";
                    
                }
            }
            else if (day == "Friday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Hamburger Helper";

                }
                else if (mealTime == "dinner")
                {
                    meal = "Chicken Parmesan";

                }
                else
                {
                    meal = "Ice Cream!";

                }
            }
            else if (day == "Saturday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Macaroni and Cheese";

                }
                else if (mealTime == "dinner")
                {
                    meal = "Steak and Potatos";

                }
                else
                {
                    meal = "Ice Cream!";

                }
            }
            else if (day == "Sunday")
            {
                if (mealTime == "lunch")
                {
                    meal = "Eggs and Bacon";

                }
                else if (mealTime == "dinner")
                {
                    meal = "Chicken Alfredo";

                }
                else
                {
                    meal = "Ice Cream!";

                }
            }

            else
            {
                meal = "Ice Cream!";
               
            }


            return meal;

        }

        static void Main(string[] args)
        {
            string day = "";
            string mealTime = "";
            string meal = "";
            Console.WriteLine("Please enter what the day of the week is.");
            day = Console.ReadLine();
            day = day.Substring(0,1).ToUpper() + day.Substring(1).ToLower();
            Console.WriteLine("Please enter what meal it is. (Lunch/Dinner)");
            mealTime = Console.ReadLine();

            mealTime = mealTime.ToLower();
            meal = DecideMeal(day, mealTime);

            Console.WriteLine("{0} is {1} for {2}", day, meal, mealTime);

        }
    }
}

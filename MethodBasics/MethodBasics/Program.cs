/***************************************************************
* Name        : MethodBasics
* Author      : Nicholas Jacobs
* Created     : 01/29/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program will calculate a new value for an item
*               using an initial price and a percent discount and then 
*               return the new price to the user
*               Input:  None
*               Output: String Happy Coding!
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace MethodBasics
{
    class Program
    {
       
        private static decimal NewPrice(decimal price, decimal percentDiscount)
        {
            //write initial method NewPrice that accepts two numbers, the first is a price, 
            //the second is the percent discounct and returns the new the price.
            // the return types will be a decimal because it is dealing with money.
            //divide by 100 to get the decimal version of the percentage

            return price - price*(percentDiscount/100);
            
        }
        
           
       
        private static void DisplayNumericData(decimal numberToDisplay)
        {
            //Method that formats the data
            //void because it isn't returning anything
            //print to 2 decimal places
            Console.WriteLine("{0:C}", numberToDisplay);
           
        }

        static void Main(string[] args)
        {

            decimal price = 44.99M;
            decimal discount = 25M;
            DisplayNumericData(NewPrice(price, discount));

        }
    }
}

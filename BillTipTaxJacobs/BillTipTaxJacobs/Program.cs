using System;
/***************************************************************
* Name        : BillTipTax
* Author      : Nicholas Jacobs
* Created     : 01/23/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program will calculate how the bill of a dinner 
*               is split between people
*               Input:  None
*               Output: Subtotal: $55.33
                        Tax: $3.87
                        Tip: $11.07
                        Total: $70.27
                        Per Person: $35.13
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace BillTipTaxJacobs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize constants
            const decimal TAX_RATE = .07M;
            const decimal TIP_PERCENTAGE = .20M;


            //Declare and initialize meals/desserts. (adding in number of people dining)
            decimal numOfPeople = 0;
            decimal mealOne = 0;
            decimal mealTwo = 0;
            decimal dessertOne = 0;
            decimal dessertTwo = 0;

            //prompt user for input
            //try catch for num of people dining
            try
            {
                Console.WriteLine("How many people will be dining?");
                numOfPeople = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Invalid response format.");
                numOfPeople = 0;
            }
            // try catches for meals and desserts

            try
            {
                Console.WriteLine("How much does meal one cost?");
                mealOne = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Invalid response format.");
                mealOne = 0;
            }

            try
            {
                Console.WriteLine("How much does meal two cost?");
                mealTwo = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Invalid response format.");
                mealTwo = 0;
            }

            try
            {
                Console.WriteLine("How much does dessert one cost?");
                dessertOne = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Invalid response format.");
                dessertOne = 0;
            }

            try
            {
                Console.WriteLine("How much does dessert two cost?");
                dessertTwo = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Invalid response format.");
                dessertTwo = 0;
            }

            //Declare variables subtotal, tax, tip, total, and total per person and then calculate
            decimal subtotal;
            decimal tax;
            decimal tip;
            decimal total;
            decimal totalPer;
            subtotal = mealOne + mealTwo + dessertOne + dessertTwo;
            tax = TAX_RATE * subtotal;
            tip = TIP_PERCENTAGE * subtotal;
            total = subtotal + tax + tip;

            //divide by 0 exception
            try
            {
                totalPer = Decimal.Divide(total, numOfPeople);
            }
            catch (DivideByZeroException e2)
            {
                totalPer = 0;
            }
           

            //print values to two decimal places.
            Console.WriteLine("Subtotal: $"+ String.Format("{0:0.00}", subtotal));
            Console.WriteLine("Tax: $"+ string.Format("{0:0.00}", tax));
            Console.WriteLine("Tip: $"+ String.Format("{0:0.00}", tip));
            Console.WriteLine("Total: $"+ String.Format("{0:0.00}", total));
            Console.WriteLine("Per Person: $"+ String.Format("{0:0.00}", totalPer));



        }
    }
}

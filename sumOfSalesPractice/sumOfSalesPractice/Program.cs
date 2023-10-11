using System;

namespace sumOfSalesPractice
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Declare and initialize a sum variable
            //for (number of sales )
            //{
            //    // Prompt user for input 
            //    // Get input 
            //    // Add to sum 
            //}
            //Output sum with 2 decimal points precision

            const int NUM_SALES = 4;
            double salesTotal = 0;
            for (int i = 1; i <= NUM_SALES; i++)
            {
                Console.WriteLine("Please enter a sales: ");
                salesTotal += Convert.ToDouble(Console.ReadLine()); // Why convert here? 
            }
            Console.WriteLine("The total sales is {0:C}", salesTotal); // What makes the precison

        }

        }
    }


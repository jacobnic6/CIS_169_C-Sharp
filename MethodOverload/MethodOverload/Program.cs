/***************************************************************
* Name        : Debugger
* Author      : Nicholas Jacobs
* Created     : 01/29/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program is going to compute the avg of 3 numbers
*               for 4 different numeric data types
*               Input:  1, 3, 5
*               Output: 6
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace MethodOverload
{
    class Program
    {
        private static float Average(float num1, float num2, float num3)
        {
            float avg = ((num1 + num2 + num3) / 3);
            return avg;
            //I chose float as the return type because the method is finding the average of float numbers
        }

        private static decimal Average(decimal num1, decimal num2, decimal num3)
        {
            decimal avg = ((num1 + num2 + num3) / 3);
            return avg;
            //I chose decimal as the return type because the method is finding the average of decimal numbers
        }

        private static int Average(int num1, int num2, int num3)
        {
            int avg = ((num1 + num2 + num3) / 3);
            return avg;
            //I chose int as the return type because the method is finding the average of int numbers
        }

        private static double Average(double num1, double num2, double num3)
        {
            double avg = ((num1 + num2 + num3) / 3);
            return avg;
            //I chose double as the return type because the method is finding the average of double numbers
        }

        static void Main(string[] args)
        {
            //declare 3 variables of each type
            float numOne = 2.4F;
            float numTwo = 5.3F;
            float numThree = 6.6F;

            decimal numFour = 23.7M;
            decimal numFive = 43.9M;
            decimal numSix = 3.3M;

            int numSeven = 77;
            int numEight = 44;
            int numNine = 99;

            double numTen = 43.6;
            double numEleven =7.7;
            double numTwelve = 22.4;

            //declare 4 variables to store the averages of the 4 data types.
            
            float floatAvg = Average(numOne, numTwo, numThree);
            Console.WriteLine("The average of the float numbers is: {0:G}", floatAvg);

            decimal decimalAvg = Average(numFour, numFive, numSix);
            Console.WriteLine("The average of the decimal numbers is: {0:G}", decimalAvg);

            int intAvg = Average(numSeven, numEight, numNine);
            Console.WriteLine("The average of the int numbers is: {0:G}", intAvg);

            double doubleAvg = Average(numTen, numEleven, numTwelve);
            Console.WriteLine("The average of the double numbers is: {0:G}", doubleAvg);



        }
    }
}

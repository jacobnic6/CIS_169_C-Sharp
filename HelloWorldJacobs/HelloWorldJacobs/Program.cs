using System;
/***************************************************************
* Name        : Debugger
* Author      : Nicholas Jacobs
* Created     : 01/16/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  None
*               Output: String Happy Coding!
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace HelloWorldJacobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Nicholas Jacobs"; // enter your name here           
            string favoriteColor = "green"; // change to your favorite
            string favoriteFood = "steak"; // change if you wish
            Console.WriteLine("Name: " + name);
            Console.Write("favorite thing to eat: " + favoriteFood);
            Console.WriteLine(" but it's not even " + favoriteColor);
            int quantity = 5;
            decimal price = 3.99M;
            decimal totalCost = quantity * price;
            Console.WriteLine("It will cost " + totalCost);
        }
    }
}

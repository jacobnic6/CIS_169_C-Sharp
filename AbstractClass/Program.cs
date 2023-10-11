/***************************************************************
* Name        : AbstractClass
* Author      : Nicholas Jacobs
* Created     : 03/27/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program overall description here
*               Input:  "Falcons", "Rugby Ball", 12
*               Output: Falcons requires 12 people, and Rugby Ball.
                Rugby is a team sport where your team tries to get the ball across the goal line.
                The number of players needed to make a rugby team is: 12
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/
using System;

namespace AbstractClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            //get input and use it to create a new instance of our classes
            Rugby rugby = new Rugby("Falcons", "Rugby Ball", 12);
            Sport shotput = new ShotPut("Eagles", "Field and Shot put", 3);

            //test our methods
            Console.WriteLine(rugby.ToString());
            Console.WriteLine(shotput.ToString());

            Console.WriteLine(rugby.Play());
            Console.WriteLine("The number of players needed to make a rugby team is: " + rugby.FormTeam());

            Console.WriteLine(shotput.Play());
        }
    }
}

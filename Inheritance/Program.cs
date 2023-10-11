/***************************************************************
* Name        : Inheritance
* Author      : Nicholas Jacobs
* Created     : 03/21/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program inherits properties from a parent class and uses it to print information to the user
*               Input:  string fname2 = "Kim", lname2 = "Possible";
                        int id2 = 32;
                        DateTime dob2 = new DateTime(2002, 6, 7);
                        decimal pay = 10.15M;
                        double hours = 19;
*               Output: Name: Kim Possible ID: 32 Hourly pay: 10.15 Hours worked: 19
                        Name Plate:
                        Last name: Possible, First name: Kim, Rate of pay: 10.15
                        Pay: 192.85
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fname = "Ren", lname = "Stevens";
            int id = 22;
            DateTime dob = new DateTime(1984, 3, 20);

            string fname2 = "Kim", lname2 = "Possible";
            int id2 = 32;
            DateTime dob2 = new DateTime(2002, 6, 7);
            decimal pay = 10.15M;
            double hours = 19;

            Student ren = new Student(fname, lname, dob, id);
            Console.WriteLine(ren.ToString());
            Console.WriteLine("age: " + ren.CalculateAge());
            Console.WriteLine("Name Plate: \n" + ren.MakeNamePlate());


            StudentWorker kim = new StudentWorker(pay, hours, fname2, lname2, dob2, id2);
            Console.WriteLine(kim.ToString());
            Console.WriteLine("Name Plate: \n" + kim.MakeNamePlate());
            kim.CalculatePay();

        }
    }
}

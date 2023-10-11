/***************************************************************
* Name        : Class using a Collection of Objects
* Author      : Nicholas Jacobs
* Created     : 03/6/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program creates a list of houses and displays their address, number of bathrooms and the number of bedrooms in them to the user
*               Input:  houseList.Add(new House() { Address = "233 W. Lexington St. Long Branch, NJ 07740", NumberBathrooms = 2, NumberBedrooms = 3 });
                        houseList.Add(new House() { Address = "9383 Sycamore Street Manchester Township, NJ 08759", NumberBathrooms = 1, NumberBedrooms = 1 });
                        houseList.Add(new House() { Address = "7093 East Church Drive Eau Claire, WI 54701", NumberBathrooms = 3, NumberBedrooms = 5 });
                        houseList.Add(new House() { Address = "83 NE. Kirkland St. North Wales, PA 19454", NumberBathrooms = 2, NumberBedrooms = 4 });
                        houseList.Add(new House() { Address = "53 Eagle St. Muncie, IN 47302", NumberBathrooms = 2, NumberBedrooms = 2 });
*               Output: House at 233 W. Lexington St. Long Branch, NJ 07740 has 3 bedrooms and 2 bathrooms.
                        House at 9383 Sycamore Street Manchester Township, NJ 08759 has 1 bedrooms and 1 bathrooms.
                        House at 7093 East Church Drive Eau Claire, WI 54701 has 5 bedrooms and 3 bathrooms.
                        House at 83 NE. Kirkland St. North Wales, PA 19454 has 4 bedrooms and 2 bathrooms.
                        House at 53 Eagle St. Muncie, IN 47302 has 2 bedrooms and 2 bathrooms.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;
using System.Collections.Generic;

namespace ObjectsInArraysAndLists
{
   public class Program
    {
         public static void Main(string[] args)
        {
            
            //write driver to make list of type house
            List<House> houseList = new List<House>();
            // adds 5 new houses to the list
            houseList.Add(new House() { Address = "233 W. Lexington St. Long Branch, NJ 07740", NumberBathrooms = 2, NumberBedrooms = 3 });
            houseList.Add(new House() { Address = "9383 Sycamore Street Manchester Township, NJ 08759", NumberBathrooms = 1, NumberBedrooms = 1 });
            houseList.Add(new House() { Address = "7093 East Church Drive Eau Claire, WI 54701", NumberBathrooms = 3, NumberBedrooms = 5 });
            houseList.Add(new House() { Address = "83 NE. Kirkland St. North Wales, PA 19454", NumberBathrooms = 2, NumberBedrooms = 4 });
            houseList.Add(new House() { Address = "53 Eagle St. Muncie, IN 47302", NumberBathrooms = 2, NumberBedrooms = 2 });

            // print list calling the ToString() method
            houseList.ForEach(delegate (House personHouse)
            {
                Console.WriteLine(personHouse.ToString());
            });
        }
    }
}

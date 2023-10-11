/***************************************************************
* Name        : Debugger
* Author      : Nicholas Jacobs
* Created     : 02/9/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program is designed to tell the closest and farthest distance from one city to another
*               Input:  None
*               Output: Printing the mileage table:
                        0
                        290
                        373     102
                        496     185     228
                        193     110     208     257
                        214     90      165     270     73
                        412     118     150     81      191     198
                        222     86      173     285     41      34      201
                        112     2017    301     360     94      155     288     141
                        186     129     231     264     25      97      194     66      82
                        Closest mileage to Manchester: 34 miles to Liverpool
                        Farthest mileage to Manchester: 285 miles to Dover

* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace JaggedArrays
{
    class Program
    {
        public static int Min(int[] arrayOne)
        {
            if (arrayOne.Length == 0)//handles empty arrays
            {
                throw new Exception("Empty Array");
            }
            int min = int.MaxValue; //starts with biggest number and loops until it has found the smallest and returns it
            foreach (int i in arrayOne)
                {
                    if (i < min)
                    {
                    min = i;
                    }
                }
            return min;
        }

        public static int Max(int[] arrayOne)
        {
            if (arrayOne.Length == 0)//handles empty arrays
            {
                throw new Exception("Empty Array");
            }
            int max = int.MinValue;//starts with smallest number and loops until it has found the biggest and returns it
            foreach (int i in arrayOne)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            string[] cityList = {"Edinburgh", "Birmingham", "Cardiff",
                 "Dover", "Leeds", "Liverpool", "London", "Manchester",
                 "NewCastle", "York" };     //declare string array

            
            int[][] mileageTable = new int[cityList.Length][];  //declare jagged array of the mileages from one city to another
            mileageTable[0] = new int[1] { 0 };
            mileageTable[1] = new int[1] { 290 };
            mileageTable[2] = new int[2] { 373, 102 };
            mileageTable[3] = new int[3] { 496, 185, 228 };
            mileageTable[4] = new int[4] { 193,110, 208, 257 };
            mileageTable[5] = new int[5] { 214, 90, 165, 270, 73 };
            mileageTable[6] = new int[6] { 412, 118, 150, 81, 191, 198 };
            mileageTable[7] = new int[7] { 222, 86, 173, 285, 41, 34, 201 };
            mileageTable[8] = new int[8] { 112, 2017, 301, 360, 94, 155, 288, 141 };
            mileageTable[9] = new int[9] { 186, 129, 231, 264, 25, 97, 194, 66, 82 };

            Console.WriteLine("\nPrinting the mileage table:");
            int cityIndex = Array.IndexOf(cityList, "Manchester");  //Index Manchester so we can use it in the min/max methods
            int closestMiles = Min(mileageTable[cityIndex]);        //declare variable for Min() 
            int closestCityIndex = Array.IndexOf(mileageTable[cityIndex], closestMiles);    //declare variable for index of city closest to Manchester
            int farthestMiles = Max(mileageTable[cityIndex]);
            int farthestCityIndex = Array.IndexOf(mileageTable[cityIndex], farthestMiles);//same as min but just for Max()

            foreach(int[] milesRow in mileageTable)     //print jagged array using nested loop
                {
                    //Console.Write();

                    for (int column = 0; column < milesRow.Length; column++)
                    {
                        Console.Write(milesRow[column] + "\t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine("Closest mileage to Manchester: " + closestMiles + " miles to " + cityList[closestCityIndex] );
            Console.WriteLine("Farthest mileage to Manchester: " + farthestMiles + " miles to " + cityList[farthestCityIndex]);

        }
    }
}

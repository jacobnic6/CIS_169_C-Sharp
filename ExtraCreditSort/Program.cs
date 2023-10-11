/***************************************************************
* Name        : ExtraCreditSort
* Author      : Nicholas Jacobs
* Created     : 02/19/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program is designed to take an array and sort it using the bubble method
*               Input:  int[] exampleArray = { 1, 8, 5, 15, 22, 2, 3, 41, 10 };
*               Output: Array before sort:
                        1 8 5 15 22 2 3 41 10
                        Array after sort:
                        1 2 3 5 8 10 15 22 41
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;
using System.Collections;

namespace ExtraCreditSort
{
    class Program
    {
        public static int[] SortArray(int[] arrayOne)
        {
            //
            int length = arrayOne.Length;
            int temporary = arrayOne[0];
            for (int i = 0; i < length; i++ )
            {
                for (int j = i + 1; j < length; j++ )
                {
                    if (arrayOne[i] > arrayOne[j]) //this takes the index value of i and if it is bigger than the value to the right they switch places
                                                    // this loops until the entire array is sorted
                    {
                        temporary = arrayOne[i];
                        arrayOne[i] = arrayOne[j];
                        arrayOne[j] = temporary;
                    }
                }
            }
            Console.WriteLine("Array after sort: ");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write(arrayOne[i] + " ");
            }
            Console.WriteLine();
            return arrayOne;
        }

        static void Main(string[] args)
        {
            int[] exampleArray = { 1, 8, 5, 15, 22, 2, 3, 41, 10 };
            Console.WriteLine("Array before sort: ");
            for (int i = 0; i <exampleArray.Length; i++)
            {
                Console.Write(exampleArray[i] + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine( SortArray(exampleArray));
        }
    }
}

using System;
using System.Collections.Generic;

namespace Module6Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare array and initialize. below are different ways to write one
            //cannot be changed after making without losing previous info
            //int[] myNums = { 1, 2, 3, 4, 5 };
            //myNums = new int[] { 1, 2, 3, 4, 5 };
            //myNums = new int[5];
            //myNums[0] = 1;
            //myNums[1] = 2;
            //myNums[2] = 3;
            //myNums[3] = 4;
            //myNums[4] = 5;

            //Console.WriteLine(myNums);

            //for (int i = 0; i <= myNums.Length; i++) 
            //{
            //    Console.WriteLine(myNums[i]);
            //}

            //Console.WriteLine(myNums);
            //int[] moreNums = myNums;

            //foreach (int num in moreNums)
            //{
            //    Console.WriteLine(num + ", ");
            //}
            //moreNums[0] = 100000;
            //Console.WriteLine();

            //for (int i = 0; i <= myNums.Length; i++)
            //{
            //    Console.WriteLine(myNums[i] + ", ");
            //}

            List<int> myList = new List<int>() { 1, 7, 3, 11, -11 };
            myList.Add(6);
            myList.Remove(2);
            myList.Sort();

            foreach(int num in myList)
            {
                Console.WriteLine(num);
            }

            List<List<int>> twoDList = new List<List<int>>();
            twoDList.Add(new List<int> { 1, 2, 3 });

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}

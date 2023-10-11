using System;

namespace ArrayMethod
{
    class Program
    {
        public static void AreSame(int[] arrayOne, int[] arrayTwo)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine("false");

            }
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]);
                Console.WriteLine("false");
            }

            else
            {
                Console.WriteLine("true");
            }
            
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 }; 

            AreSame(arr1, arr2);
        }
    }
}

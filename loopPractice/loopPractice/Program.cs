using System;

namespace loopPractice
{
    class Program
    {
       private static void NameMethod(string userName, int x);
            {
               int timesNameWritten = 0;
                Console.WriteLine
                for (timesNameWritten)
                

            }






        static void Main(string[] args)
        {

            /* int counter = 0;
             while (counter<5)
             {
                 Console.WriteLine(counter);
                 counter++;
             }

             int myNum = 0;
             bool valid = false;


             while(!valid)
             {
                 Console.WriteLine("Please enter a whole number");
                 valid = int.TryParse(Console.ReadLine(), out myNum);
                 Console.WriteLine(myNum);
             }*/

            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter a number between 2 and 50");
            string userNumber = Console.ReadLine();

            int x = 0;
            //userNumber = int.TryParse(userNumber)
            bool valid = int.TryParse(userNumber, out x);
            while ((2 >= x) || (x >= 50)) 
               {
                
                    Console.WriteLine("Please enter a valid number");
                    int.TryParse(Console.ReadLine(), out x);

                }

           












        }
    }
}

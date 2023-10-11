using System;

namespace Module4IfStatementsPractice
{
    class Program
    {
        
        
            static int ChoresByAge(int childAge)
        {
            Console.WriteLine("What is the age of your child");
            childAge = Int32.Parse(Console.ReadLine());

            if (childAge < 2)
            {
                Console.WriteLine("Too young for chores");
            }
            else if (childAge >= 2 && childAge <= 3)
            {
                Console.WriteLine("The child can do the following chores: Pick up toys and books, put garbage in trash," +
                    "put dirty laundry in hamper, put laundry in drawer");
            }
            else if (childAge >= 4 && childAge <= 6)
            {
                Console.WriteLine("The child can do the following chores: All previous chores, Take care of pets," +
                    "Set and clear the table, Make bed");
            }
            else if (childAge >= 7 && childAge <= 11)
            {
                Console.WriteLine("The child can do the following chores: All previous chores, Fold laundry," +
                    "Sweep and vacuum, Take out trash, Meal prep");
            }
            else if (childAge >= 12)
            {
                Console.WriteLine("The child can do the following chores: All previous chores, Babysit siblings," +
                    "Wash windows, Laundry, Mow the lawn");
            }
            else
            {
                Console.WriteLine("incorrect age format");

            }
            return childAge;

        }
        static void Main(string[] args)
        {
            //get age
            int childAge = 1;
            
            ChoresByAge(childAge);


        }
    }
}

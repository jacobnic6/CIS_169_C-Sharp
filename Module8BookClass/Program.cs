using System;

namespace Module8BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Wilson Rawls", "Where the Red Fern Grows", 1961, 9780385020596, "dog, boy, hunting");
            Console.WriteLine(myBook);

            //use default no-arg default constructor
            Book bookOne = new Book();
            bookOne.Author = "John Skeet";
            bookOne.Title = "C# in Depth";
            bookOne.PubDate = 2008;
            bookOne.ISBN = 9781617294532;
            bookOne.Keywords = "C#, Programming, Learning";
            //create book object book1
            Book book1 = new Book();
            book1.Author = "J. K. Rowling";
            book1.Title = "Harry Potter and the Sorcerer's Stone";
            book1.PubDate = 1997;
            book1.ISBN = 0439708184;
            book1.Keywords = "Wizard, Harry Potter, Spells";

            Book bookTwo = new Book("Nicholas Jacobs", "Murach’s ASP.NET Core MVC", 2020, 9781943873029, "C#, programming");

            bookTwo.Author = "Mary Delamater and Joel Murach";

            //create book2 as clone of book1
            Book book2 = new Book();
            book2 = (Book) book1.Clone();

            Console.WriteLine("\n" + bookOne);
            Console.WriteLine("\n" + bookTwo);
            
            //display book1 and clone
            Console.WriteLine("\nbook1 : " + book1.ToString());
            Console.WriteLine("\nbook2 (clone) : " + book2.ToString());



        }
    }
}

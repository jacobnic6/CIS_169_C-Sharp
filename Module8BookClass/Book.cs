/***************************************************************
* Name        : Use an Interface
* Author      : Nicholas Jacobs
* Created     : 03/27/2023
* Course      : CIS 169 - C#
* Version     : 16.4.27
* OS          : Windows 11
* IDE         : Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This progam creates a class Book with properties and prints it to the console on the Program.cs using a ToString() override
*               Input:  Book book1 = new Book();
                        book1.Author = "J. K. Rowling";
                        book1.Title = "Harry Potter and the Sorcerer's Stone";
                        book1.PubDate = 1997;
                        book1.ISBN = 0439708184;
                        book1.Keywords = "Wizard, Harry Potter, Spells";

*               Output:  book1 : Author: J. K. Rowling
                        Title: Harry Potter and the Sorcerer's Stone
                        Keywords: Wizard, Harry Potter, Spells
                        Publication date: 1997
                         ISBN: 439708184

                        book2 (clone) : Author: J. K. Rowling
                        Title: Harry Potter and the Sorcerer's Stone
                        Keywords: Wizard, Harry Potter, Spells
                        Publication date: 1997
                         ISBN: 439708184
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Module8BookClass
{

    //added ICloneable to class so we can clone it
    public class Book : ICloneable
    {
        private string _author;
        private string _title;
        private int _pubDate;
        private double _isbn;
        private string _keywords;


        public Book()
        {
            _author = "";
            _title = "";
            _pubDate = 0;
            _isbn = 0;
            _keywords = "";
        }

        public Book(string author, string title, int pubDate, double isbn, string keywords)
        {
            _author = author;
            _title = title;
            _pubDate = pubDate;
            _isbn = isbn;
            _keywords = keywords;
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int PubDate
        {
            get { return _pubDate; }
            set { _pubDate = value; }
        }

        public double ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        //Clone method of book
        public object Clone()
        {
            Book book = new Book();
            book.Author = this.Author;
            book.Title = this.Title;
            book.PubDate = this.PubDate;
            book.ISBN = this.ISBN;
            book.Keywords = this.Keywords;
            return book;
        }

        public override string ToString()
        {
            return ("Author: " + Author + "\n" + "Title: " + Title + "\n" + "Keywords: " + Keywords + "\n" + "Publication date: " + PubDate + "\n" + " ISBN: " + ISBN);
        }
    }
}

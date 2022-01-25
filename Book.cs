using System;
using System.Collections.Generic;
using System.IO;

namespace FinalPractical
{
    internal class Book
    {
        #region Fields
        private string _title;
        private string _author;
        private string _description;
        private static string _directory = "../../../";
        private static string _file = "CurrentBooks.txt";
        #endregion

        public string Title
        {
            get { return _title; }
        }

        #region Constructors
        public Book()
        {

        }

        public Book(string title, string author, string description)
        {
            _title = title;
            _author = author;
            _description = description;
        }
        #endregion


        public List<Book> ReadFile()
        {
            List<Book> books = new List<Book>();
            using (StreamReader sr = new StreamReader(_directory + _file))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    Book newBook = new Book(data[0], data[1], data[2]);   
                    books.Add(newBook);
                }

                return books;
            }
        }

        public static void AddABook()
        {
            UI.Header("add a book");

            Console.Write("Title: ");
            Console.Write("Author: ");
            Console.Write("Description: ");
            Console.ReadKey();
        }

    }
}

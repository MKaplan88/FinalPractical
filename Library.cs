using System;
using System.Collections.Generic;

namespace FinalPractical
{
    internal class Library
    {
        #region Fields
        private static string _address = "123 Main St.";
        private List<Book> _bookList = new List<Book>();
        private static string _name = "little free library";
        #endregion

        public Library()
        {
            Book book = new Book();
            _bookList = book.ReadFile();
            MainDisplay();
        }

        private void MainDisplay()
        {
            UI.Header(_name);
            Console.WriteLine(_address);
            UI.Seperator();

            Menu books = new Menu(_bookList);
            books.Display(1);

            Console.WriteLine("[0] Add a Book");
            UI.Footer("Select a Menu Option: ");
            Console.ReadKey();

        }
    }
}

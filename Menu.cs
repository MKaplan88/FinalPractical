using System;
using System.Collections.Generic;

namespace FinalPractical
{
    internal class Menu
    {
        #region Fields
        private List<Book> _menuItems;
        #endregion

        #region Constructor
        public Menu(List<Book> menuList)
        {
            _menuItems = menuList;
        }
        #endregion

        #region Display Method
        public void Display(int startNum)
        {
            foreach(Book item in _menuItems)
            {
                Console.WriteLine($"[{startNum}] {item.Title}");
                startNum++;
            }

            Console.WriteLine("");
        }
        #endregion
    }
}

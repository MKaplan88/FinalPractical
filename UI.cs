using System;

namespace FinalPractical
{
    static class UI
    {
        public static void Header(string header)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($" {header.ToUpper()}");
            Console.WriteLine("===============================================");
        }

        public static void Footer(string footer)
        {
            Console.WriteLine("\r\n-----------------------");
            Console.Write($" {footer}");
        }

        public static void Seperator()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
        }
    }
}

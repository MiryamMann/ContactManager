using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton
{
    internal class ColorPrinting
    {
        private static ColorPrinting printer;
        public static ColorPrinting Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new ColorPrinting();
                }

                return printer;
            }
        }
        private ColorPrinting() { }
        public ConsoleColor CurrentColor = ConsoleColor.Black;

        public void Print(string header, ContactPerson contact)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));

            if (contact.Properties.ContainsKey("Color"))
            {
                if (Enum.TryParse(contact.Properties["Color"], true, out ConsoleColor contactColor))
                {
                    Console.ForegroundColor = contactColor;
                    CurrentColor = contactColor;
                }
            }

            Console.WriteLine(contact.ToString());
            Console.WriteLine(new string('-', header.Length));
            Reset();
        }

        public void Reset()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            CurrentColor = ConsoleColor.Black;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace CardGame 
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Card Game Machine";
            Console.ForegroundColor = ConsoleColor.Green;
            Menu menu = new Menu();
            menu.Start();
            
        }
    }

}

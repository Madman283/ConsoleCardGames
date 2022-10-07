using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CardGame
{
    internal class Utility
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Pause()
        {
            Print("Enter any key to continue...");
            ReadKey();
        }

        

    }
}

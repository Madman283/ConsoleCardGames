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
        
        /*
         Project 1: Game Framework : Console Card Games
         
        Brandon Figueroa
        PROG 201 - 01
        10/15/2022
         
        Credits:
        Jenell Baxter (teacher) - Helped with all classes and critical game functionality.
        
        Brian Rosner (student) - Helped create this line of code in class "HighestMatch" 102 -107
        private void CheckHandValue()
        {
            for (int i = 0; i < player.hand.Count; i++)
            {
                handValue += player.hand[i].Value;
            }


        */


    }

}

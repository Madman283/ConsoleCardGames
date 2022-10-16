using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;
using static System.Console;

namespace CardGame
{
    internal class Menu
    {
        List<string> options = new List<string>() {"Apples and Oranges", "Higher or Lower", "Highest Match"};
        Game game;
        public void Start()
        {
            Print("What game would you like to play?");
            for (int i = 0; i < options.Count; i++)
            {
                Print($"{i + 1} {options[i]}");
            }
            switch (Console.ReadLine())
            {
                case "1":
                    Clear();
                    game = new ApplesAndOranges() {gameName = "Apples and Oranges", rules = "Each round you will try to what the next card will be. If you are correct you will recive a point." };
                    game.GameStart();
                    break;
                    case "2":
                    Clear();
                    game = new HigherOrLower() { gameName = "Higher Or Lower", rules = "Each round you will try to determine what the next cards value will be, if it is higher or lower than your current card. If you are right you will get a point." };
                    game.GameStart();
                    break;
                case "3":
                    Clear();
                    game = new HighestMatch() { gameName = "Highest Match", rules = "You will try to get the highest points possible, if you decide to not trade in your cards it will got to the end. If you have higher points than the dealer you win." };
                    game.GameStart();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}

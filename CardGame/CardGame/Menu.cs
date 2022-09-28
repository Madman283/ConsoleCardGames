using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;

namespace CardGame
{
    internal class Menu
    {
        List<string> options = new List<string>() {"Apples and Oranges", "Higher or Lower", "Highest Match"};
        Game game;
        public void Start()
        {
            Print("Please select an options");
            for (int i = 0; i < options.Count; i++)
            {
                Print($"{i + 1} {options[i]}");
            }
            switch (Console.ReadLine())
            {
                case "1":
                    game = new ApplesAndOranges() {gameName = "Apples and Oranges", rules = "Rules are here" };
                    game.GameStart();
                    break;
                    case "2":
                    game = new HigherOrLower() { gameName = "Higher Or Lower", rules = "These are rules" };
                    game.GameStart();
                    break;
                case "3":
                    game = new HighestMatch() { gameName = "Highest Match", rules = "Rulzzz" };
                    game.GameStart();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}

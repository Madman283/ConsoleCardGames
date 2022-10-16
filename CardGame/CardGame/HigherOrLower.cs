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
    internal class HigherOrLower:Game
    {
        public override void GameStart()
        {
            Clear();
            base.GameStart();
            //custom content

            deck.ConstructDeck(13, new string[] { "Clubs", "Spades", "Hearts", "Diamonds" });
            deck.Shuffle();

            while (deck.cards.Count >= 2)
            {
                GamePlay();
            }
            if (deck.cards.Count <= 2)
            {
                EndResult();
            }

        }

        private void GamePlay()
        {
            string input;

            Card a = deck.Draw();
            Print($"The first card drawn is... {a.Value} of {a.Suit}");
            Print("Is the next card Higher or Lower? H/L?");
            input = ReadLine();
            Card b = deck.Draw();
            Print($"The second card drawn is... {b.Value} of {b.Suit}");
            if (a.Value < b.Value && input.ToUpper() == "H")
            {
                //player gets point
                player.score++;
                Print("You are correct!");
            }
            else if (a.Value > b.Value && input.ToUpper() == "L")
            {
                //player gets point
                player.score++;
                Print("You are correct!");
            }
            else
            {
                Print("Sorry that is incorrect...");
            }
            Print($"Your score is {player.score}!");
            Pause();
            Clear();
        }

        private void EndResult()
        {
            Print("You did it! You finished the game.");
            Print($"You finished the game with {player.score} points!");
            Pause();
            StartNewGame();
            

        }
        private void StartNewGame()
        {
            ReadKey(true);
            Clear();
            Menu menu2 = new Menu();
            menu2.Start();

        }


    }
}

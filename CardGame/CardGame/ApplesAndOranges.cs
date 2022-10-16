using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;
using static System.Console;

namespace CardGame
{
    internal class ApplesAndOranges:Game
    {
         
       
        public override void GameStart()
        {

            Clear();
            base.GameStart();
            //custom content
            deck.ConstructDeck(13, new string[]{"Apples", "Oranges"} );
            //deck.OutputCards();
            deck.Shuffle();

            while (deck.cards.Count >= 2)
            {
                GamePlay();
            }
            


        }

        private void GamePlay()
        {
            string input;

            Card a = deck.Draw();
            Print($"The first card drawn is... {a.Value} of {a.Suit}");
            Print("Is the next card the same or different suit? S/D?");
            input = ReadLine();
            Card b = deck.Draw();
            Print($"The second card drawn is... {b.Value} of {b.Suit}");
            if (a.Suit == b.Suit && input.ToUpper() == "S")
            {
                //player gets point
                player.score++;
                Print("You are correct!");
            }
            else if (a.Suit != b.Suit && input.ToUpper() == "D")
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


            Print("This is the end");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;
using static System.Console;

namespace CardGame
{
    internal class HighestMatch:Game
    {
        bool play = true;
        
        public override void GameStart()
        {
            base.GameStart();
            //make deck 52 card 4 suits, suffle deck
            deck.ConstructDeck(13, new string[] { "Clubs", "Spades", "Hearts", "Diamonds" });
            deck.Shuffle();

            //deal 4 cards to player
            player.hand.Add(deck.Draw());
            player.hand.Add(deck.Draw());
            player.hand.Add(deck.Draw());
            player.hand.Add(deck.Draw());

            //4 cards to the dealer
            dealer.hand.Add(deck.Draw());
            dealer.hand.Add(deck.Draw());
            dealer.hand.Add(deck.Draw());
            dealer.hand.Add(deck.Draw());

            //if not just show current cards
            for (int i = 0; i < 10; i++)
            {
                if (play)
                {
                    Round();

                }
                
            }
            EndResult();

            //show player his new card and current cards
            //end round

            //at the end of the game the game will tally up your highest match or highest card available as your final score.

            //10 rounds
            //custom content
        }

        private void Round()
        {
            int number = 1;
            foreach (var item in player.hand)
            {
                Print(number + "." + item.ShowCard());
                number++;
            }

            //ask player if they want to switch out 1 card
            Print("Would you like to swap 1 of your cards? Y/N?");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Print("Which card would you like to choose 1-4?");
                input = ReadLine();
                switch (input)
                {
                    case "1":
                        player.hand.RemoveAt(0);
                        break;
                    case "2":
                        player.hand.RemoveAt(1);
                        break;
                    case "3":
                        player.hand.RemoveAt(2);
                        break;
                    case "4":
                        player.hand.RemoveAt(3);
                        break;


                    default:
                        break;
                }
                player.hand.Add(deck.Draw());

            }
            else
            {
                //return;
                play = false;
            }
        }

        private void EndResult()
        {
            Print("This is the end");
            
        }


    }
}

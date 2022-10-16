using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
        int handValue;
        int dealerValue;

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
                Clear();

            }
            else
            {
                //return;
                play = false;
            }
        }
        

        private void CheckHandValue()
        {
            for (int i = 0; i < player.hand.Count; i++)
            {
                handValue += player.hand[i].Value;
            }

            for (int i = 0; i < dealer.hand.Count; i++)
            {
                dealerValue += dealer.hand[i].Value;
            }

            if (handValue >= dealerValue)
            {
                Print("You Win!");
            }
            else
            {
                Print("You lose, better luck next time...");
            }
            if (handValue == dealerValue)
            {
                Print("It is a Draw! ");
            }

        }
        private void EndResult()
        {

            CheckHandValue();
            Print($"Your hand value was {handValue}.");
            Print($"Dealer hand value was {dealerValue}.");
            Print("Thanks for playing!");
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

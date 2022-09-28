using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        private int[] value = {1,2,3,4,5,6,7,8,9,10,11,12,13};
        private string[] suit = { "Clubs", "Spades", "Hearts", "Diamonds" };
        public List<Card> cards = new List<Card>();

        public void Shuffle()
        {
            Random rand = new Random();
            cards = cards.OrderBy(x => rand.Next()).ToList();
        }

        public void ConstructDeck()
        {
            for (int i = 0; i < suit.Length; i++)
            {
                for (int v = 0; v < value.Length; v++)
                {
                    cards.Add(new Card(value[v], suit[i]));
                }
            }
        }

        public void ConstructDeck(int valueN, string[] suit)
        {
            for (int i = 0; i < suit.Length; i++)
            {
                for (int v = 0; v < valueN; v++)
                {
                    cards.Add(new Card(v + 1, suit[i]));
                }
            }
        }



        public void OutputCards()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine($"{cards[i].Value} of {cards[i].Suit}");
            }
        }

        public Card Draw()
        {
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private string suit;
        private int value;

        public string Suit { get { return suit; } set { suit = value; } }
        public int Value { get { return value; } set { this.value = value; } }

        public Card(int value, string suit)
        {
            Suit = suit;
            Value = value;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        public string name;
        public int score = 0;
        
        public Queue<Card> queue = new Queue<Card>();
        public Stack<Card> stack = new Stack<Card>();
        public List<Card> hand = new List<Card>();

        
    }
}

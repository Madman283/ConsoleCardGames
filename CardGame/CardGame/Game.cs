using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Utility;

namespace CardGame
{
    internal class Game
    {
        public Player dealer = new Player();
        public Player player = new Player();
        public Deck deck = new Deck();

        public string gameName;
        
        public string rules = "This is the rules";

        public virtual void GameStart()
        {
            Print(gameName);
            Print(rules);
        }


    }
}

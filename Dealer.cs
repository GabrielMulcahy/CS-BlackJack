using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Dealer : Player
    {
        private Deck Deck;

        public Dealer(Deck deck) : base("Dealer")
        {
            Deck = deck;
            deck.Shuffle();
            deck.Riffle();

            Deal(this, 2);            
        }

        public void Deal(Player player, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++) 
            {
                player.Hand.Put(Deck.Draw());
            }
        }

        public PlayingCard RevealSecondCard()
        {
            return Hand.Get(1);
        }
    }
}

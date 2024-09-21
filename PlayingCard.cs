using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class PlayingCard
    {
        public CardValue Value { get; private set; }
        public CardSuit Suit { get; private set; }

        public PlayingCard(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

}

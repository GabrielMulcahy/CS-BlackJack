using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Hand
    {
        private List<PlayingCard> Cards;

        public Hand()
        {
            Cards = new List<PlayingCard>();
        }

        public void Put(PlayingCard card) 
        { 
            Cards.Add(card); 
        }

        public int CalculateValue()
        {
            int value = 0;
            foreach (var card in Cards) 
            {
                value += (int)card.Value;
            }
            return value;
        }

        public PlayingCard Get(int index) 
        { 
            return Cards[index];
        }

        public void Empty()
        {
            Cards = new List<PlayingCard>();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var card in Cards)
            {
                stringBuilder.Append(card.ToString());
                stringBuilder.Append('\n');
            }
            return stringBuilder.ToString();
        }
    }

}

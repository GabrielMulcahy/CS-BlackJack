using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private List<PlayingCard> Cards;

        public Deck()
        {
            Cards = new List<PlayingCard>();

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    Cards.Add(new PlayingCard(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;

            for (int i = Cards.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                PlayingCard value = Cards[rnd];
                Cards[rnd] = Cards[i];
                Cards[i] = value;
            }
        }

        public void Riffle()
        {
            var firstHalf =  Cards.Take(Cards.Count / 2).ToList();
            var secondHalf = Cards.Skip(Cards.Count / 2).ToList();

            int maxLength = Math.Max(firstHalf.Count, secondHalf.Count);

            Cards = new List<PlayingCard>();

            for (int i = 0; i < maxLength; i++)
            {
                if (i  < firstHalf.Count)
                {
                    Cards.Add(firstHalf[i]);
                }
                if (i < secondHalf.Count)
                {
                    Cards.Add(secondHalf[i]);
                }
            }
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

        public PlayingCard Draw()
        {
            PlayingCard card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}

using System;

namespace BlackJack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play Blackjack!");

            var deck = new Deck();
            Dealer dealer = new Dealer(deck);

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Player player = new Player(name);

            dealer.Deal(player, 2);

            Console.WriteLine($"The Dealer's second card is: {dealer.RevealSecondCard()}");

            Console.WriteLine($"Your hand is:\n{player.Hand}");
            Console.WriteLine($"Combined total of: {player.Hand.CalculateValue()}");

            if(player.Hand.CalculateValue() == 21) {
                Console.WriteLine("Blackjack!!!");
                return;
            }

            Console.WriteLine($"Hit or stand?");

            string choice = Console.ReadLine();

            while (choice == "hit")
            {
                dealer.Deal(player, 1);
                Console.WriteLine($"Your new hand is:\n{player.Hand}");
                Console.WriteLine($"So a total of: {player.Hand.CalculateValue()}\n");
                if (player.Hand.CalculateValue() > 21)
                {
                    Console.WriteLine("You lose!");
                    return;
                }
                Console.WriteLine("Hit or stand?");
                choice = Console.ReadLine();
            }

            Console.WriteLine($"Dealer's hand is:\n{dealer.Hand.ToString()}");
            Console.WriteLine($"So a total of: {dealer.Hand.CalculateValue()}\n");

            while (dealer.Hand.CalculateValue() < 17)
            {
                Console.WriteLine("Dealer hits...");
                dealer.Deal(dealer, 1);
                Console.WriteLine($"Dealer's hand is:\n{dealer.Hand.ToString()}");
                Console.WriteLine($"So a total of: {dealer.Hand.CalculateValue()}\n");
                if (dealer.Hand.CalculateValue() > 21)
                {
                    Console.WriteLine("Dealer busts! You win!");
                    return;
                }
            }

            if (dealer.Hand.CalculateValue() < player.Hand.CalculateValue())
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}

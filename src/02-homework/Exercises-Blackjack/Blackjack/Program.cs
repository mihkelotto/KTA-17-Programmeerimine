using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack");
            Console.WriteLine();
            PlayBlackjack();
        }

        public static void PlayBlackjack()
        {
            Deck shuffledDeck = new Deck();
            Hand[] playerHand = new Hand[2];
            GetNames(playerHand);
            InitialDeal(playerHand, shuffledDeck);

            PlayerDecision(playerHand, shuffledDeck);
            DealerDecision(playerHand, shuffledDeck);

            ShowEndResult(playerHand);

            Console.ReadLine();

        }

        public static void GetNames(Hand[] player)
        {
            player[0] = new Hand("Player");
            player[1] = new Hand("House");
        }

        public static void InitialDeal(Hand[] player, Deck shuffledDeck)
        {

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i <= 1; i++)
                {
                    player[i].TakeCard(shuffledDeck.DealCard());
                }
            }
        }

        public static void PlayerDecision(Hand[] player, Deck shuffledDeck)
        {
            for (int i = 0; i < player.GetUpperBound(0); i++)
            {
                WritePlayerHand(i, true, player);
                Console.WriteLine();
                for (int j = 0; j <= player.GetUpperBound(0); j++)
                {
                    if (j != i)
                    {
                        WritePlayerHand(j, false, player);
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                string hitChoice;

                if (player[0].score == 21)
                {
                    hitChoice = "9";
                }

                do
                {
                    Console.WriteLine($"Your score is {player[i].score}.");
                    Console.WriteLine();
                    Console.WriteLine($"What would you like to do?");
                    Console.WriteLine();
                    Console.WriteLine("Choose: 1 - To take another card");
                    Console.WriteLine("Choose: 2 - To finnish");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write("I Choose: ");
                        hitChoice = Console.ReadLine();
                        Console.WriteLine();
                        if (!(hitChoice == "1" || hitChoice == "2"))
                        {
                            Console.WriteLine("Wrong input enter 1 or 2");
                        }
                        if (hitChoice == "1" || hitChoice == "2")
                        {
                            break;
                        }
                    }
                    if (hitChoice == "1")
                    {
                        player[i].TakeCard(shuffledDeck.DealCard());
                        if (player[0].score < 21)
                        {
                            WritePlayerHand(i, true, player);
                            Console.WriteLine();
                            ShowWinnerStatus(player[i].score, player[player.GetUpperBound(0)].score, false);
                        }
                        if (player[i].score >= 21) { break; }
                    }

                } while (hitChoice == "1" || !(hitChoice == "2"));
                continue;
            }
        }
        public static void DealerDecision(Hand[] player, Deck shuffled_Deck)
        {
            while (player[1].score < 16)
            {
                player[1].TakeCard(shuffled_Deck.DealCard());
            }
        }

        public static void ShowWinnerStatus(int score, int dealerScore, bool EndResult)
        {
            if (score == 21)
            {
                Console.WriteLine("Winner, you hit 21!");
                EndResult = false;
            }
            else if (score > 21)
            {
                Console.WriteLine("House wins!");
                EndResult = false;
            }
            if (EndResult == true)
            {
                if (score < dealerScore && dealerScore <= 21)
                {
                    Console.WriteLine("House wins!");
                }
                else if ((score > dealerScore && dealerScore < 21) || (score < dealerScore && dealerScore > 21))
                {
                    Console.WriteLine("Player wins!");
                }
                else if ((score < 21 && dealerScore < 21) && score == dealerScore)
                {
                    Console.WriteLine("It's a draw!");
                }
            }
        }
        public static void WritePlayerHand(int index, bool hideHand, Hand[] player)
        {
            Console.Write($"{player[index].playerAndDealer} has been dealt:");
            if (hideHand == false)
            {
                Console.Write($"   {player[index].hand[0].ToString()}");
                for (int i = 1; i <= player[index].hand.GetUpperBound(0); i++)
                {
                    Console.Write("   [?]");
                }

            }
            else
            {
                for (int i = 0; i <= player[index].hand.GetUpperBound(0); i++)
                {
                    Console.Write($"   {player[index].hand[i].ToString()}");
                }
            }
        }
        public static void ShowEndResult(Hand[] player)
        {
            WritePlayerHand(0, true, player);
            Console.WriteLine();
            WritePlayerHand(1, true, player);


            Console.WriteLine();
            Console.WriteLine($"{player[0].playerAndDealer} has { player[0].score} points vs. {player[1].playerAndDealer} has {player[1].score} points");
            Console.WriteLine();
            ShowWinnerStatus(player[0].score, player[player.GetUpperBound(0)].score, true);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
        }
    }
}

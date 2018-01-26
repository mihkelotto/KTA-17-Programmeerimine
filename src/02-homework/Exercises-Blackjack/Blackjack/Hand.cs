using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Hand
    {
        public Card[] hand { get; private set; }
        public string playerAndDealer { get; private set; }
        public int score { get; private set; }

        public Hand(string p)
        {
            score = 0;
            playerAndDealer = p;
        }

        public void TakeCard(Card dealtCard)
        {
            if (hand == null)
            {
                hand = new Card[1];
                hand[0] = dealtCard;
            }
            else
            {
                Card[] temporaryHand = hand;
                hand = new Card[temporaryHand.Length + 1];
                temporaryHand.CopyTo(hand, 0);
                hand[hand.GetUpperBound(0)] = dealtCard;
            }
            Score();
        }

        private void Score()
        {
            score = 0;
            bool ace = false;
            foreach (Card cardHand in hand)
            {
                switch (cardHand.cardRank)
                {
                    case Card.Rank.Ace:
                        score += 1;
                        ace = true;
                        if (ace == true && score + 10 <= 21)
                        {
                            score += 10;
                        }
                        break;
                    case Card.Rank.Two:
                        score += 2;
                        break;
                    case Card.Rank.Three:
                        score += 3;
                        break;
                    case Card.Rank.Four:
                        score += 4;
                        break;
                    case Card.Rank.Five:
                        score += 5;
                        break;
                    case Card.Rank.Six:
                        score += 6;
                        break;
                    case Card.Rank.Seven:
                        score += 7;
                        break;
                    case Card.Rank.Eight:
                        score += 8;
                        break;
                    case Card.Rank.Nine:
                        score += 9;
                        break;
                    case Card.Rank.Ten:
                        score += 10;
                        break;
                    case Card.Rank.Jack:
                        score += 10;
                        break;
                    case Card.Rank.Queen:
                        score += 10;
                        break;
                    case Card.Rank.King:
                        score += 10;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}

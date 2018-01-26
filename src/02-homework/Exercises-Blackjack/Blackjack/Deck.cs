using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Deck
    {
        private Card[] deck;
        private int drawnCards = 0;

        public Deck()
        {
            deck = new Card[52];
            for (int suit = 0; suit < Enum.GetNames(typeof(Card.Suit)).Length; suit++)
            {

                for (int rank = 0; rank < Enum.GetNames(typeof(Card.Rank)).Length; rank++)
                {
                    deck[(suit * (Enum.GetValues(typeof(Card.Rank)).Length)) + rank] = new Card((Card.Suit)suit, (Card.Rank)rank);
                }
            }
            Shuffle();
        }



        private void Shuffle()
        {
            Random rnd = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int random = (int)(rnd.Next(i + 1));
                Card temp = deck[i];
                deck[i] = deck[random];
                deck[random] = temp;
            }
        }

        public Card DealCard()
        {
            if (drawnCards > deck.GetUpperBound(0))
            {
                Shuffle();
                drawnCards = 0;
                return deck[drawnCards++];
            }
            else
            {
                return deck[drawnCards++];
            }
        }
    }
}

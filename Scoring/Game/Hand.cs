using System.Collections.Generic;

namespace Scoring.Game
{
    public class Hand
    {
        public Card[] Cards;

        public Hand()
        {
            Cards = new Card[13];
        }

        public bool IsComplete()
        {
            foreach (Card c in Cards)
            {
                if (c == null)
                {
                    return false;
                }
            }
            return true;
        }

        public bool Contains(Card card)
        {
            if (card == null)
            {
                return false;
            }
            foreach (Card c in Cards)
            {
                if (card.Equals(c))
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Card c)
        {
            for (int i = 0; i < 13; i++)
            {
                if (Cards[i] == null)
                {
                    Cards[i] = c;
                    return;
                }
            }
        }

        public List<Card> GetCardsWithinSuit(Suit suit)
        {
            List<Card> ret = null;
            foreach (Card c in Cards)
            {
                if (c != null && c.Suit == suit)
                {
                    if (ret == null)
                    {
                        ret = new List<Card>();
                    }
                    ret.Add(c);
                }
            }
            return ret;
        }

        public void DddCards(List<Card> cards)
        {
            foreach (Card c in cards)
            {
                Add(c);
            }
        }

        public void RemoveSuit(Suit suit)
        {
            for (int ix = 0; ix < 13; ix++)
            {
                if (Cards[ix] != null && Cards[ix].Suit == suit)
                {
                    Cards[ix] = null;
                }
            }
            // Fill empty slots:
            // ("Stable" removeSuit)
            int i = 0;
            int j = 1;
            while (i < 13 && j < 13)
            {
                if (Cards[i] == null)
                {
                    if (j <= i)
                        j = i + 1;
                    while (j < 13)
                    {
                        if (Cards[j] != null)
                        {
                            Cards[i] = Cards[j];
                            Cards[j] = null;
                            break;
                        }
                        j++;
                    }
                }
                i++;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCardGame
{
    class deck
    {
        public List<card> cards {get; private set; }

        public deck()
        {
            cards = new List<card>();
            createDeck();
        }
        public void createDeck()
        {
            List<string> Suits = new List<string> { "diamonds", "spades", "hearts", "clubs" };
            List<string> Values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace", };
            // here i have all the suits and values for a deck of cards.

            foreach (string suits in Suits)
            {
                foreach (string values in Values)
                {
                    cards.Add(new card(suits, values));
                    // This adds every possible card combo to 'cards'.
                }
            }
                
        }
        public string Deal()
        {
            if (cards.Count > 0)
            {
                card topcard = cards[0];
                cards.Remove(topcard);
                return topcard.ToString();
            }
            return "no cards left, sorry!";
        }
        public bool IsEmpty()
        {
            if (cards.Count < 1)
            return true;
                else return false;
        }
        public void shuffle()
        {
            Random rnd = new Random();
            int count = cards.Count();
            while (count > 1)
            {
                count--;
                int rng = rnd.Next(count);
                var value = cards[rng];
                cards[rng] = cards[count];
                cards[count] = value;
                // this will shuffle the deck

            }
        }
    }
}

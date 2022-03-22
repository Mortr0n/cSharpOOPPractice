using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return this.cards; }
        }

        public Deck()
        {
            Reset();
        }

        public List<Card> Reset()
            {    
                cards.Clear();
                for(int x = 0; x < 4; x++)
                {
                    for(int y = 1; y < 14; y++)
                    {
                        cards.Add(new Card(Card.Suits[x], y));
                    }                        
                }
                return cards;
            }
        }

        public void ShowDeck()
        {
            foreach(Card card in cards)
            {
                card.WriteCard();
            }
        }
}
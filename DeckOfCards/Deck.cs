namespace DeckOfCards
{
    class Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            string[] suits = {"Hearts", "Clubs", "Spades", "Diamonds"};
            string[] cardTypes = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            Cards = new List<Card>();
                
            public Deck makeDeck()
            {    
                    for(int x = 0; x < suits.Length; x++)
                    {
                        for(int y = 0; y < cardTypes.Length; y++)
                        {
                            Card card = new Card(suits[x], cardTypes[y], y);
                        }
                        
                    }

                }
        }
    }
}
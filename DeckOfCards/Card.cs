namespace DeckOfCards
{
    class Card{
        private string stringVal;
        private string suit;
        private int val;

        public Card(string thisSuit, string cardType, int thisVal)
        {
            stringVal = cardType;
            suit = thisSuit;
            val = thisVal;
        }
    }

    
}
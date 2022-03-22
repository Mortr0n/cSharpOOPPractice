using System;

namespace DeckOfCards
{
    class Card{
        private string stringVal;
        private string suit;
        private int value;

        public static string[] Suits = new string[4] {"Hearts", "Clubs", "Spades", "Diamonds"};
        public Card(string s, int val)
        {
            switch (val)
            {
                case 11:
                    stringVal = "Jack";
                    break;
                case 12:
                    stringVal = "Queen";
                    break;
                case 13:
                    stringVal = "King";
                    break;
                case 1:
                    stringVal = "Ace";
                    break;
                default:
                    stringVal = val.ToString();
                    break;
            }
            suit = s;
            value = val;
        }
        

        public void WriteCard()
        {
            Console.WriteLine($"The {stringVal} of {suit}");
        }
    }

    
}